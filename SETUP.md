
# 🧪 Setup Instructions for Digital Banking Microservice + React Login

## Prerequisites
- .NET 8 SDK
- Node.js 18+
- Docker (if using DB/message broker)

## Backend Setup (UserService)
```bash
cd backend/Services/UserService/User.API
dotnet restore
dotnet run
```
Service runs on: `https://localhost:5001`

## Frontend Setup
```bash
cd frontend
npm install
npm run dev
```
App runs on: `http://localhost:5173`

## Auth API (Simulated)
For testing, mock a login POST endpoint at:
`POST http://localhost:5001/api/auth/login`
Respond with:
```json
{ "token": "eyJhbGciOiJIUzI1NiIsInR5cCI..." }
```

Then use this token to hit:
`GET http://localhost:5001/api/user/profile` with `Authorization: Bearer <token>` header.
