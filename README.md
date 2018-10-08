# GRASP Patterns NetCore

GRASP significa General Responsability Assignment Software Patterns
Similar a los principios SOLID, y pueden aplicarse en conjunto
Ambos son considerados buenas prácticas en el ámbito del desarrollo de sofware orientado a objetos

Son 9 patrones:
- Creator
- Information Expert
- Low Coupling
- Controller
- High Cohesion
- Indirection
- Polymorphism
- Protected Variations
- Pure Fabrication

## Patrón Controller
La clase CustomersController recibe mensajes de la interfaz de usuario y se encarga de coordinar y controlar todas las acciones necesarias para atender la solicitud del usuario.

Por ejemplo, el método SignUp de la clase CustomersController es responsable de atender el caso de uso "Dar de alta a un cliente", que involucra crear una organización, crear un usuario "propietario" de la organización, y un proyecto inicial asociado a la organización.

## Definición API REST

Dar de alta un cliente
```
POST /v1/customers/signup
{
	"OrganizationName": "UNT",
	"Username": "juan.lopez",
	"Password": "superseguro",
	"ProjectName": "AFP Integra",
	"Budget": 10000.00,
	"CurrencyCode": "PEN"
}
```