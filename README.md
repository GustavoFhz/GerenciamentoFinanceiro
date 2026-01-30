# 💰 Gerenciamento Financeiro

Este é um sistema de **Gerenciamento Financeiro** desenvolvido em ASP.NET Core MVC. A aplicação permite o controle total de finanças pessoais, possibilitando o registro de ganhos e gastos, categorização de transações e visualização de balanço financeiro com filtros inteligentes.

## 🚀 Funcionalidades

* **Gestão de Finanças:** Adicionar e remover registros financeiros (valor, data, categoria e tipo).
* **Categorização Dinâmica:** Cadastro de novas categorias para organizar melhor os gastos.
* **Filtros Inteligentes:**
* Por Categoria.
* Por Tipo de Transação (Ganho/Gasto).
* Por Período (Passado, Hoje, Futuro).


* **Resumo de Balanço:**
* Cálculo automático de somatória por categoria.
* Cálculo de Total de Ganhos vs. Total de Gastos.
* Exibição da diferença (saldo líquido).



## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** ASP.NET Core MVC
* **ORM:** Entity Framework Core
* **Banco de Dados:** SQL Server (ou SQLite conforme configuração do `AppDbContext`)
* **Frontend:** Razor Pages (HTML, CSS)

---

## 🏗️ Estrutura do Controlador Principal

O `HomeController` gerencia a lógica central do sistema:

1. **Index:** Realiza consultas complexas no banco de dados utilizando `IQueryable` para aplicar múltiplos filtros simultâneos.
2. **SomatoriaValores:** Utiliza **LINQ** e `group by` para consolidar os dados financeiros e apresentar um relatório de saldo.
3. **Filtragem:** Sistema de rotas dinâmicas que concatena filtros em uma `string id` para buscas precisas.

---

## 🔧 Como rodar o projeto

1. **Clone o repositório:**
```bash
git clone https://github.com/GustavoFhz/seu-repositorio.git

```


2. **Configure o Banco de Dados:**
Certifique-se de ajustar a `ConnectionString` no arquivo `appsettings.json`.
3. **Execute as Migrations:**
```bash
dotnet ef database update

```


4. **Inicie a aplicação:**
```bash
dotnet run

```

## 📚 Contexto

Projeto desenvolvido como parte de um curso, servindo como base de aprendizado.
A partir dele, realizei adaptações e melhorias próprias.


---

## 👤 Autor

Desenvolvido por **Gustavo Fhz**.

Sinta-se à vontade para entrar em contato ou visitar meu perfil:

---
