
## Software architecture

### 1. Dependencies between layers

Presentation Layer
│
└─> Application Layer
    │
    └─> Domain Layer
    │   ^
    │   │
    │   └─ Infrastructure Layer
    │
    └─> Infrastructure Layer

### 2. Structure of each layer in a software architecture

Presentation Layer
├── Controllers
├── Views
├── View Models
└── Client-side Code

Application Layer
├── Application Services
└── Data Transfer Objects (DTOs)

Domain Layer
├── Entities
├── Value Objects
├── Aggregates
├── Repositories
├── Domain Services
└── Specifications

Infrastructure Layer
├── External Services
├── Event Handlers
├── Persistence Models
└── Implementations
