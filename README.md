# Usuario

Projeto fullstack com backend em .NET e frontend em Angular. O objetivo é gerenciar usuarios, com autenticação e CRUD completo.

## 🧱 Estrutura

```
projetos/
├── backend/    # Projeto .NET com API REST
├── frontend/   # Projeto Angular SPA
```

---

## 🔧 Backend (.NET 6+)

### Tecnologias
- ASP.NET Core Web API
- Dapper + PostgreSQL
- JWT Auth
- Clean Architecture (Controller, Repository, ViewModel)

### Como rodar

```bash
cd backend
dotnet restore
dotnet run
```

- Porta padrão: `https://localhost:5001`
- Swagger: `https://localhost:5001/swagger`

---

## 💻 Frontend (Angular)

### Tecnologias
- Angular 15+
- Bootstrap 5
- Consumo de API REST

### Como rodar

```bash
cd frontend
npm install
ng serve
```

- Porta padrão: `http://localhost:4200`

---

## ✅ Funcionalidades

- [x] Login com JWT
- [x] Cadastro e edição de contatos WhatsApp
- [x] Listagem e exclusão
- [x] Integração com API backend
- [x] Interface responsiva (Bootstrap)

---

## 📂 Exemplo de uso da API

### Login
`POST /api/auth/login`

### Lista WhatsApp
`GET /api/whatsapp`

---

## 👨‍💻 Autor

Desenvolvido por **Davy**

---

## 📝 Licença

MIT
