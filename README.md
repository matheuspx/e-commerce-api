## 📚 Sobre o Projeto

A E-commerce API com funcionalidades de cadastro e gerenciamento de clientes, produtos e empresas, incluindo ordens de pagamento, o sistema conta com autenticação, controle de acesso, fechamento de pedidos e uma arquitetura MVC, aplicando conceitos de camadas para garantir a manutenibilidade do sistema

### Funcionalidades Principais

- **Cadastro de Usuários**: Permite criar contas para empresas, consumidores e administradores.
- **Gerenciamento de Produtos**: Adicione, edite e remova produtos do catálogo.
- **Gerenciamento de Pedidos**: Acompanhamento completo das ordens de pagamento.
- **Autenticação e Autorização**: Autenticação de usuários e controle de acesso baseado em roles.

## 🏗️ Arquitetura do Projeto


- **Manutenibilidade**: Facilita a adição de novas funcionalidades.
- **Separação de Responsabilidades**: Cada camada possui funções específicas e bem definidas.
- **Escalabilidade**: Uma base sólida para crescimento futuro do sistema.

## 🛠️ Tecnologias Utilizadas

- **Tecnologias**: .NET, Entity Framework,FluentValidation, FluentMigrator, Dependency Injection, 
- **Banco de Dados**: MySQL
- **Documentação da API**: Swagger


## 🚀 Como Executar o Projeto

### Pré-requisitos

- .NET SDK 6.0+

### Instalação

1. **Clone o repositório**:
   ```sh
   git clone https://github.com/seu-usuario/ecommerce-platform.git
   cd ecommerce-platform
   ```

2. **Restaure as dependências**:
   ```sh
   dotnet restore
   ```

3. **Configurar o banco de dados**:
   Crie um banco de dados MySQL e configure a string de conexão no arquivo `appsettings.json` dentro da pasta `Ecommerce.API`.

   ```json
   {
     "ConnectionStrings": {
       "ConnectionMySql": "Server=localhost;Database=ecommercedb;Uid=root;Pwd=root;"
     },
     "Settings": {
       "Jwt": {
         "SigningKey": "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww",
         "ExpirationTimeMinutes": 1000
       }
     }
   }
   ```

4. **Inicie o servidor**:
   Após configurar o banco de dados, inicie o servidor localmente:
   ```sh
   dotnet run --project src\Backend\Ecommerce.API
   ```

   O sistema estará disponível em `http://localhost:5027`.

   Acesse o Swagger para testar os endpoints: `http://localhost:5027/swagger`.




---

Este README fornece uma visão geral do projeto, suas funcionalidades, tecnologias utilizadas, instruções de uso e informações de contato. Você pode personalizar ainda mais conforme necessário.
