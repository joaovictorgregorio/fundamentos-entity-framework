<div align="center">
  <img src="images/logo-balta.png" alt="balta.io" height="60"/>
  <h1>Fundamentos do Entity Framework</h1>
  <p>Repositório de anotações e códigos de estudo do curso oferecido pela <a href="https://balta.io">balta.io</a></p>
</div>

---

## 📚 Sumário

- [📌 Introdução](#introdução)
- [🛠️ Operações Básicas](#operações-básicas)
- [🧩 Mapeamento](#mapeamento)
- [🧱 Migrações](#migrações)
- [🚀 Performance e Outros](#performance-e-outros)

---

## 📌 Introdução

> Breve overview sobre o que é o Entity Framework, vantagens, tipos de abordagens (Code First, Database First), e como ele se integra ao .NET.

- O que é o EF Core?
- ORM vs ADO.NET
- Instalação e configuração básica
- Tipos de abordagem: `Code First`, `Database First`, `Model First`

---

## 🛠️ Operações Básicas

> Comandos e métodos essenciais para interação com o banco de dados.

- `Add`, `Update`, `Remove`, `Find`, `FirstOrDefault`, `ToList`
- `SaveChanges()`: persistência das alterações
- Consultas com `LINQ`
- `Include`: carregamento de dados relacionados
- Trabalhando com `DbSet<TEntity>`

---

## 🧩 Mapeamento

> Uso do Fluent API para mapear entidades às tabelas do banco.

- `ToTable`, `HasKey`, `HasIndex`, `HasDefaultValue`, `HasDefaultValueSql`
- Relacionamentos:
  - `HasOne`, `WithMany`, `WithOne`, `HasMany`
  - Muitos para muitos com `UsingEntity`
- Nomeação de FKs com `HasConstraintName`
- Estratégias de deleção: `DeleteBehavior.Cascade`, `Restrict`, `SetNull`

---

## 🧱 Migrações

> Como versionar a estrutura do banco com segurança usando migrações.

- `Add-Migration`
- `Update-Database`
- Remover ou refazer migrações
- Boas práticas para ambientes de desenvolvimento

---

## 🚀 Performance e Outros

> Recursos adicionais para melhorar a eficiência e controle.

- `AsNoTracking` para consultas mais rápidas
- `LogTo(Console.WriteLine)` para exibir SQL gerado
- `ChangeTracker` e estados de entidades
- Cuidados com `N+1`, tracking excessivo, e uso de `Select`

---

## 🤝 Créditos

Este repositório foi criado com base no curso **[Fundamentos do Entity Framework](https://balta.io/cursos)** oferecido pela plataforma [balta.io](https://balta.io).

---

<div align="center">

🧑‍💻 Criado com dedicação para estudos pessoais.  
📌 Sinta-se livre para usar como base e contribuir.

</div>
