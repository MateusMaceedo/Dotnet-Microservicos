### Dotnet-Microservicos

- Micro-Serviços Serverless, na prática com .Net Core, AWS Lambda, SQS e SNS.

- Conta id: 950034207364
- Usuarios: treinamento
- Acess Key: AKIA52MTTSKCHVGJ7N2T
- Secret Key: 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

- Comando para criar a lambda:
``` dotnet new -i Amazon.Lambda.Templates::* ```

``` dotnet new serverless.AspNewCoreWebAPI --name Cadastrador --region us-east-1 ```

Criando a classlib:
``` dotnet new classlib -o Compartilhado ```

Criando uma solução:
``` dotnet new sln -o AppWeb ```

Publicar a lambda na AWS:
``` dotnet publish -p:PublishReadyToRun=true ```

- Documentação para criar API via CLI do dotnet:
https://www.macoratti.net/19/10/net_climp1.htm

<h1 align="center">
  <img src="https://github.com/MateusMaceedo/Dotnet-Microservicos/blob/main/img/diagrama.png?raw=true" alt="diagrama.png">
</h1>
