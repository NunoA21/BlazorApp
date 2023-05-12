**Blazor Tutorial**

This tutorial is from Microsoft Learning Paths, you can see it here: <https://learn.microsoft.com/pt-pt/training/paths/build-web-apps-with-blazor/>.

1. Se quiser correr o projeto de forma a que faça hot reload, podemos usar o seguinte comando:
   `dotnet watch run` (se quiser parar, posso usar o comando Ctrl + C, se quiser fazer restart uso o Ctrl + R)
   Esta ação irá compilar e iniciar a aplicação e, em seguida, reconstruir e reiniciar a aplicação sempre que efetuar alterações no código.

2.Criar a página ToDo:
2.1. Correr o comando `dotnet new razorcomponent -n Todo -o Pages`
A `-n|--name` opção no comando anterior especifica o nome do novo componente do Razor. O novo componente é criado na pasta do Pages projeto com a opção `-o|--output` .


Existem dois modelos de alojamento para código nas aplicações do Blazor:

- Blazor Server: neste modelo, a aplicação é executada no servidor Web numa aplicação ASP.NET Core. As atualizações de IU, eventos e chamadas JavaScript no lado do cliente são enviadas através de uma ligação SignalR entre o cliente e o servidor. Neste módulo, vamos debater e codificar para este modelo.
- Blazor WebAssembly: neste modelo, a aplicação Blazor, as respetivas dependências e o runtime do .NET são transferidos e executados no browser.
