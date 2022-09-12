
# Clima Tempo Simples

Este projeto tem por objetivo listar o ranking das cidades mais frias e mais quentes previstas para o dia atual e listar a previsão do tempo para os próximos 7 dias de acordo com a cidade selecionada no filtro.

## Execução do sistema

Na pasta raíz do projeto (a mesma que contém a solução), atualize o banco de dados SQL Server com o seguinte comando:

```power shell
  dotnet ef database update
```

O projeto já possui um Migration preparado com um inicializador de dados, portanto o banco será criado e populado automaticamente.

Para adicionar/alterar dados do banco de dados, pode-se acessá-lo manualmente, ou editar o arquivo "ClimaTempoSimplesBuilderExtensions.cs", localizado em
``` path
  ...ClimaTempo\DAL\ClimaTempoSimplesBuilderExtensions.cs
```

O método Seed é responsável por popular o banco de dados inicialmente.

Após a alteração, é necessário criar um novo Migration com o comando:

``` Power Shell
  dotnet ef migrations add [MigrationName]
```

E, novamente, é necessário atualizar o banco de dados com o seguinte comando:
```Power Shell
  dotnet ef database update
```

Para iniciar o servidor da aplicação, é necessário executar o comando "build" no projeto. Para isso, abra-o no visual studio (ou em alguma IDE compatível) e pressione Ctrl+Shift+B. Também é possível executar a mesma ação clicando com o botão direito do mouse em cima do projeto ouda solução e clicando em "Build"ou "Build Solution".

Após isso, você pode iniciar o aplicativo pela própria IDE, pressionando Ctrl+F5, ou clicando no botão de iniciar, localizado na barra superior.
Outra forma de iniciar o sistema é acessando a pasta de arquivos binários gerada na ação anterior e executando o arquivo ClimaTempo.exe.