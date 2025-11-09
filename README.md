## 🧠 Online Quiz Platform API


> >Online Quiz Platform API is a comprehensive system for creating, publishing, and taking quizzes. It supports dynamic question addition, result calculation, user authentication, asynchronous answer processing via RabbitMQ, and deployment through Docker Compose.
---
## 🧩 Key Features

- 🧩 CRUD operations for quizzes and questions
- 🧮 Automatic score calculation
- 🔐 JWT authentication and authorization
- 🧱 DDD / Clean Architecture / Repository + Unit of Work patterns
- 🐇 Asynchronous inter-service communication via RabbitMQ
- ⚙️ Pagination, filtering, and sorting
- 🐳 Docker Compose orchestration (PostgreSQL + RabbitMQ + services)
- 📜 Swagger/OpenAPI documentation
- 🏗 Architecture

The platform follows a microservices architecture with  main services:

### 📝 Quiz Management Service

- Manages quizzes, questions, and answer options
- CRUD operations and publishing
- PostgreSQL data storage
- API prefix: /api/quizzes 

###  🧮 Scoring Service

- Processes submitted answers
- Calculates final scores and stores results
- Consumes messages from RabbitMQ
- API prefix: /api/scoring
- Infrastructure Components

### 🧠API Gateway (Ocelot) - Single entry point for all client requests
- PostgreSQL - Relational database
- RabbitMQ - Message broker for async communication
- Docker Compose - Container orchestration

### 🐳 Docker Compose
- Orchestrates the entire infrastructure:
    - **Shop API**
    - **Shop Auth Service**
    - **API Gateway**
    - **PostgreSQL** instances
    - **Redis** cache
    - **RabbitMQ** message broker

### 📦 Project Structure

```
OnlineQuizPlatform/
│
├── QuizManager.API/                 # Quiz Management Service
│   ├── Application/
│   ├── Domain/
│   ├── Infrastructure/
│   ├── Presentation/
│   └── Program.cs
│
├── ScoringService.API/              # Scoring Service
│   ├── Application/
│   ├── Domain/
│   ├── Infrastructure/
│   ├── Presentation/
│   └── Program.cs
│
├── OnlinQuizAPI.Gateway/            # API Gateway
│   ├── configuration.json
│   ├── ocelot.swagger.json
│   └── Program.cs
│
├── docker-compose.yml
└── README.md
```

## ⚙️ Technologies Used

| Category | Tools & Frameworks |
|-----------|--------------------|
| **Language** | C# (.NET 8) |
| **Web Framework** | ASP.NET Core Web API |
| **ORM / Data Access** | Dapper |
| **Gateway** | Ocelot |
| **Message Broker** | RabbitMQ |
| **Cache** | Redis |
| **Database** | PostgreSQL |
| **Containerization** | Docker, Docker Compose |
| **Mapping / Utils** | AutoMapper, ILogger |
| **Architecture** | Microservices, Event-Driven |

---

#### Access the services:

- API Gateway: http://localhost:7000/swagger
- Quiz Management API: http://localhost:8001/swagger
- Scoring Service API: http://localhost:8002/swagger
- RabbitMQ Management: http://localhost:15672 (guest/guest)
- PostgreSQL: localhost:5433

### 🐳 Docker Services

The system consists of the following containers:

- quiz-api-gateway (Port 7000) - API Gateway with Ocelot
- quiz-manager-api (Port 8001) - Quiz Management Service
- scoring-service-api (Port 8002) - Scoring Service
- quiz-db (Port 5433) - PostgreSQL database
- quiz-rabbitmq (Ports 5672, 15672) - RabbitMQ with management UI

### 🧪 Testing

Use the Swagger UI at http://localhost:7000/swagger to test all endpoints. Example test flow:

Register a new user
Create a quiz
Add questions to the quiz
Submit answers
Check results


## ✨ Author

Gor Muradkhanyan
Software Developer 
### 📬 Contact

**Gor Muradkhanyan**  
📧 Email: [gormuradxanyan@gmail.com](mailto:gormuradxanyan@gmail.com)  
💼 LinkedIn: [linkedin.com/in/gormuradxanyan](https://www.linkedin.com/feed/)
⸻
