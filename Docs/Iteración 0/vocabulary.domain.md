---

id: vocabulary.dominio
type: domain-vocabulary
status: active
scope: iteration
related:
  - [context.scenario](context.scenario.md)
  - [scope.iteration](scope.iteration.md)
  - [process.household-shopping](process.household-shopping.md)
  - [improvement.future-evolution](improvement.future-evolution.md)
  - [implementation.artifact](implementation.artifact.md)

---

# Vocabulario dominio It. 0

## Compra mensual

Compra recurrente destinada a cubrir productos esenciales del hogar durante un mes.

## Lista mensual de compra

Lista estable de productos y cantidades que se espera comprar cada mes.

## Lista preparada

Lista de productos que ya existe antes del momento en que se necesita comprar.

* usos: Se usa para distinguir una lista accionable de una lista que todavía debe reconstruirse manualmente.

## Producto de compra

Elemento específico que se desea comprar como parte de una lista mensual.

## Cantidad

Número de unidades que se desea comprar de un producto.

## Enlace de producto

URL directa a un producto disponible en un mercado externo.

## Mercado

Proveedor externo donde se puede realizar una compra.

## Líder

Mercado específico usado actualmente para realizar la compra mensual.

## Carrito

Representación de productos seleccionados dentro de un mercado antes de pagar.

## Preparar carrito

Acción de transformar una lista mensual accionable en productos seleccionados dentro de un mercado.

## Pago

Momento en que el dinero queda disponible o se ejecuta una transacción.

## Día de pago

Momento crítico en que el dinero necesario para la compra mensual queda disponible.

## Dinero destinado a despensa

Parte del dinero disponible que debería cubrir productos esenciales del hogar.

## Dispersión del dinero

Situación donde el dinero disponible se gasta antes de cubrir la compra mensual esperada.

* usos: Se usa para describir el riesgo principal que este Slice-First busca reducir.

## Carga ejecutiva

Esfuerzo mental necesario para planificar, decidir, recordar y ejecutar una tarea.

* ejemplos: "Reconstruir la lista en el momento de comprar aumenta la carga ejecutiva."
* usos: Se usa para explicar por qué una tarea simple puede fallar si depende de energía mental disponible.

## TDAH

Condición que puede aumentar la dificultad para sostener tareas repetitivas, planificación previa y ejecución oportuna.

* usos: Se usa como parte del contexto real del escenario, no como explicación única del problema.

## Compra anterior

Registro histórico de productos comprados previamente en una tienda.

* ejemplos: "La aplicación de Líder puede mostrar compras anteriores."
* usos: Se usa para distinguir historial de compra de lista mensual preparada.
