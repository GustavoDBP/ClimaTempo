function loadData() {
    loadRank();
    loadOverviewFilter();
}
function loadRank() {
    $("#top3Hottest").empty();
    $("#top3Coldest").empty();
    function loadByQuery(query, topList) {
        topList.every((value, index) => {
            if (index >= 3) return false;

            const container = $(query);

            let forecast_div = document.createElement("div");
            let forecastCity_span = document.createElement("span");
            let forecastMin_span = document.createElement("span");
            let forecastMax_span = document.createElement("span");

            forecastCity_span.innerText = value.cidade + "/" + value.uf;
            forecastMin_span.innerText = "Min " + value.min + " ºC";
            forecastMax_span.innerText = "Max " + value.max + " ºC";

            forecast_div.append(forecastCity_span);
            forecast_div.append(forecastMin_span);
            forecast_div.append(forecastMax_span);
            container.append(forecast_div);

            return true;
        });
    }

    $.get(
        "/previsao/ranking",
        function (data) {
            loadByQuery("#top3Hottest", data.topQuentes);
            loadByQuery("#top3Coldest", data.topFrias);
        }
    )
}
function loadOverviewFilter() {
    function loadOptions(options) {
        const filter = $("#citySelect");
        filter.empty();
        options.forEach((value) => {
            let option = document.createElement("option");

            option.innerText = value.nome;
            option.setAttribute("value", value.id);

            filter.append(option);
        });

        filter.on("change", function () {
            loadOverviewData(this.value);
        });

        loadOverviewData(filter.find("option:first-child").val());
    }

    $.get(
        "/previsao/cidades",
        function (data) {
            loadOptions(data);
        }
    )
}

function loadOverviewData(cidadeId) {
    function loadCards(overviewData) {
        const container = $("#overviewCards");
        const weekday = ["domingo", "segunda-feira", "terça-feira", "quarta-feira", "quinta-feira", "sexta-feira", "sábado"];
        const climateIconClass = { "Ensolarado": "sunny-day", "Nublado": "cloudy-day", "Chuvoso": "rainny-day", "Tempestuoso": "tempest-day" }
        const climateText = { "Ensolarado": "Ensolarado", "Nublado": "Nublado", "Chuvoso": "Chuvoso", "Tempestuoso": "Tempestuoso" }

        container.empty();

        overviewData.every((value, index) => {
            if (index >= 7) return false;

            let card_div = document.createElement("div");
            let cardHeader_div = document.createElement("div");
            let cardHeader_h3 = document.createElement("h3");
            let cardContent_div = document.createElement('div');
            let overviewClimate_div = document.createElement('div');
            let climateIcon_i = document.createElement("i");
            let climateText_span = document.createElement("span");
            let min_span = document.createElement("span");
            let max_span = document.createElement("span");

            card_div.classList.add("card", "overview-card");
            cardHeader_h3.innerText = weekday[new Date(value.dataPrevisao).getDay()];
            climateIcon_i.classList.add("climate-icon", climateIconClass[value.clima])
            climateText_span.innerText = climateText[value.clima];
            min_span.innerText = "Mínima: " + value.min + 'ºC';
            max_span.innerText = "Máxima: " + value.max + 'ºC';

            card_div.append(cardHeader_div);
            card_div.append(cardContent_div);
            cardHeader_div.append(cardHeader_h3);
            cardContent_div.append(overviewClimate_div);
            overviewClimate_div.append(climateIcon_i);
            overviewClimate_div.append(climateText_span);
            cardContent_div.append(min_span);
            cardContent_div.append(max_span);

            container.append(card_div);

            return true;
        })
    }

    $.get(
        "/previsao/resumo/" + cidadeId,
        function (data) {
            loadCards(data);
        }
    )
}

loadData();