# Exemplo de uma aplicação com o DotVVM
Demo apresentado na palestra _Construindo uma aplicação web + MVVM + .NET Core_. Apresentação: https://goo.gl/dAQDU4

# Estrutura do Repositório
* DotVVMExample: Pasta contendo uma aplicação web feita em DotVVM.

# Passos para executar o projeto
* Instale o .NetCore no seu sistema.
* Instale o Visual Studio Code.
* Instale a extensão para C# no VS Code.
* Clone esse repositório.
* Abra a pasta DotVVMExample no Vs Code.
* Execute na aba de _Debug_ do VS Code

# Criando um projeto DotVVM através da Command Line
* Abra o terminal.
* Instale as extensões do DOtVVM com o comando: 

```
dotnet new -i DotVVM.Templates::*
```

* Crie um diretório:
```
mkdir ProjectName
cd ProjectName
dotnet new dotvvm
``` 

* Crie uma Master Page através do comando:
```
dotnet dotvvm add master Site
```

* Crie uma página filha da Master:
```
dotnet dotvvm add page Page1 -m Site
```

* Para custom controls utilize o comando:
```
dotnet dotvvm add control Controls/MyControl.dotcontrol -c
```