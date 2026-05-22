# Vista de casos de uso: Gestión de productos del hogar

## Objetivo de la vista

Describir los casos de uso candidatos para el flujo de gestión de productos del hogar, tomando como base el escenario manual previamente identificado.

Esta vista busca representar qué capacidades debería ofrecer el sistema para apoyar a los miembros del hogar en la consulta, incorporación, consumo y control de productos existentes en el inventario doméstico.

El objetivo principal no es definir todavía la implementación técnica, sino establecer una lectura funcional del sistema: qué actores interactúan con él, qué acciones realizan, qué problemas del flujo manual se intentan mitigar y qué casos quedan fuera del alcance inicial.

Esta vista servirá como punto de entrada para las siguientes vistas del modelo 4+1, especialmente la vista lógica y la vista de procesos.

---

## Contexto del escenario manual

En el flujo manual, la gestión de productos del hogar ocurre principalmente mediante observación física, memoria individual y comunicación informal entre miembros del hogar.

Cuando una persona necesita saber si un producto está disponible, normalmente debe ir a una o más ubicaciones y revisar físicamente si existe stock. Cuando se compra un producto, este se incorpora al inventario físico al ser guardado, pero no necesariamente queda disponible como conocimiento compartido. Cuando se consume o usa un producto, el stock real disminuye, pero ese cambio rara vez queda registrado.

Esto provoca problemas como:

- Falta de visibilidad sobre productos disponibles.
- Falta de trazabilidad sobre entradas, salidas, descartes y pérdidas.
- Dependencia de memoria individual.
- Conocimiento fragmentado entre miembros del hogar.
- Compras duplicadas.
- Sobrestock.
- Quiebres de stock detectados demasiado tarde.
- Pérdida de productos por vencimiento.
- Dificultad para saber si una cantidad disponible es suficiente.

La aplicación busca reducir estas fricciones entregando una representación consultable, actualizable y compartida del inventario del hogar.

---

# Decisión conceptual de Iteración 1

Durante el análisis del escenario manual se identificó que muchas acciones aparentemente distintas representan en realidad variaciones de una misma operación fundamental sobre el inventario.

Por ejemplo:

- Registrar producto.
- Registrar reposición.
- Registrar compra.

Todas representan entradas de inventario.

De la misma forma:

- Registrar consumo.
- Registrar agotamiento.
- Registrar descarte.
- Registrar pérdida.

Representan salidas de inventario.

Por esta razón, la primera iteración reducirá el flujo a un conjunto mínimo de operaciones fundamentales:

1. Consultar disponibilidad de producto.
2. Registrar entrada de inventario.
3. Registrar salida de inventario.
4. Evaluar bajo stock.

Los conceptos de ubicación explícita, vencimiento, lista de compras, descarte especializado y movimientos avanzados se reconocen como relevantes, pero quedarán fuera del alcance inicial para mantener el núcleo del dominio pequeño y coherente.

---

## Diagrama de casos de uso de Iteración 1

```mermaid
flowchart TB
    Actor["Miembro del hogar"]

    subgraph Inventory["Sistema: Gestión de productos del hogar"]

        Consultar["Consultar disponibilidad de producto"]

        RegistrarEntrada["Registrar entrada de inventario"]

        RegistrarSalida["Registrar salida de inventario"]

        EvaluarStock["Evaluar bajo stock"]

        SugerirReposicion["Sugerir reposición"]
    end

    Actor --> Consultar
    Actor --> RegistrarEntrada
    Actor --> RegistrarSalida

    RegistrarSalida -. "include" .-> EvaluarStock
    RegistrarEntrada -. "include" .-> EvaluarStock

    EvaluarStock -. "extend" .-> SugerirReposicion
````

---

## Lectura del diagrama

El miembro del hogar es el actor principal del flujo.

El sistema debe permitir consultar el estado actual del inventario y registrar operaciones que modifiquen el stock disponible.

En esta iteración, todas las modificaciones relevantes del inventario se modelan mediante dos tipos fundamentales de operación:

* Entradas de inventario.
* Salidas de inventario.

Las entradas representan incorporaciones de stock al hogar.

Las salidas representan reducciones de stock producidas por consumo, agotamiento, pérdida o cualquier otra causa.

Después de cada operación relevante, el sistema puede evaluar condiciones derivadas, como bajo stock o necesidad de reposición.

Las relaciones `include` representan comportamientos obligatorios asociados a otro caso de uso.

Las relaciones `extend` representan comportamientos opcionales o condicionales derivados de una evaluación previa.

---

## Actor principal en sistema propuesto

### Miembro del hogar

Representa a cualquier persona que vive en el hogar o participa en su administración cotidiana.

En el sistema propuesto, el miembro del hogar puede:

* Consultar productos disponibles.
* Registrar entradas de inventario.
* Registrar salidas de inventario.
* Revisar condiciones de bajo stock.
* Revisar sugerencias de reposición.

No se distinguirán inicialmente perfiles avanzados como administrador, comprador o invitado.

Todos los comportamientos funcionales se concentrarán inicialmente en el actor `Miembro del hogar`.

Esta decisión mantiene simple el modelo inicial y evita introducir jerarquías o permisos antes de consolidar el dominio principal.

---

## Casos de uso candidatos

| Código | Caso de uso                          | Actor principal   | Tipo           | Prioridad |
| ------ | ------------------------------------ | ----------------- | -------------- | --------- |
| UC-001 | Consultar disponibilidad de producto | Miembro del hogar | Consulta       | Alta      |
| UC-002 | Registrar entrada de inventario      | Miembro del hogar | Comando        | Alta      |
| UC-003 | Registrar salida de inventario       | Miembro del hogar | Comando        | Alta      |
| UC-004 | Evaluar bajo stock                   | Sistema           | Regla derivada | Alta      |
| UC-005 | Sugerir reposición                   | Sistema           | Regla derivada | Media     |

---

# Descripción resumida de casos de uso

## UC-001: Consultar disponibilidad de producto

Permite que un miembro del hogar consulte si existe disponibilidad de un producto específico en el inventario.

El sistema debería responder:

* Si el producto existe.
* Qué cantidad se encuentra disponible.
* Si el producto se encuentra bajo stock.

Este caso busca reducir la necesidad de revisar físicamente el hogar antes de tomar una decisión.

---

## UC-002: Registrar entrada de inventario

Permite incorporar stock al inventario del hogar.

Este caso representa cualquier operación que aumente la cantidad disponible de un producto.

Ejemplos:

* Compra de productos.
* Reposición de existencias.
* Donación.
* Recuperación manual.
* Registro inicial de inventario.

El sistema debe permitir registrar:

* Producto.
* Cantidad.
* Unidad de medida.

Si el producto no existía previamente, el sistema puede incorporarlo al inventario.

Si el producto ya existe, el sistema debe aumentar su stock disponible.

Después de registrar una entrada, el sistema debe reevaluar condiciones derivadas como bajo stock.

---

## UC-003: Registrar salida de inventario

Permite reducir stock disponible desde el inventario del hogar.

Este caso representa cualquier operación que disminuya la cantidad disponible de un producto.

Ejemplos:

* Consumo.
* Agotamiento.
* Pérdida.
* Derrame.
* Corrección manual.
* Descarte.

El sistema debe permitir registrar:

* Producto.
* Cantidad.
* Unidad de medida.

Después de registrar una salida, el sistema debe reevaluar condiciones derivadas como bajo stock.

---

## UC-004: Evaluar bajo stock

Permite que el sistema determine si un producto quedó por debajo de un umbral mínimo definido.

Esta evaluación puede ocurrir después de cualquier modificación relevante del inventario.

El resultado puede activar sugerencias de reposición.

Este caso no es iniciado directamente por el miembro del hogar, sino derivado automáticamente por el sistema.

---

## UC-005: Sugerir reposición

Permite que el sistema sugiera reponer un producto cuando detecta una condición relevante como:

* Bajo stock.
* Agotamiento.
* Tendencia de reducción significativa.

La sugerencia no implica automáticamente una compra.

Representa una recomendación visible para el miembro del hogar.

---

# Problemas del flujo manual que mitiga cada caso

| Caso de uso                          | Problemas mitigados                                                                                  |
| ------------------------------------ | ---------------------------------------------------------------------------------------------------- |
| Consultar disponibilidad de producto | Reduce revisión física, incertidumbre, dependencia de memoria y compras duplicadas.                  |
| Registrar entrada de inventario      | Mejora trazabilidad de incorporaciones y reduce desconocimiento compartido sobre nuevas existencias. |
| Registrar salida de inventario       | Reduce visión desactualizada del inventario y mejora consistencia del stock disponible.              |
| Evaluar bajo stock                   | Permite detectar automáticamente condiciones de riesgo antes del agotamiento total.                  |
| Sugerir reposición                   | Reduce dependencia de memoria y comunicación informal para recordar compras futuras.                 |

---

# Casos fuera de alcance para esta iteración

Los siguientes casos se reconocen como relevantes, pero quedan fuera del alcance inicial para mantener pequeño el núcleo del dominio.

## Gestión explícita de ubicaciones

Aunque el escenario manual evidencia que la ubicación es relevante, esta iteración no modelará explícitamente el concepto de ubicación de almacenamiento.

Inicialmente, el inventario será tratado a nivel global del hogar.

---

## Gestión de vencimiento

No se modelarán fechas de vencimiento ni productos próximos a vencer.

El concepto se reconoce como importante, especialmente para productos perecibles, pero requiere modelar existencias más detalladas.

---

## Gestión avanzada de movimientos

En esta iteración existirán únicamente dos tipos fundamentales de movimiento:

* Entrada.
* Salida.

Subtipos específicos como:

* Consumo.
* Descarte.
* Pérdida.
* Ajuste manual.
* Reposición.

quedan como evolución posterior del modelo.

---

## Lista de compras

La lista de compras se reconoce como flujo relacionado, pero no forma parte del núcleo inicial del inventario.

Las sugerencias de reposición no crearán automáticamente elementos de compra.

---

## Escaneo de códigos de barra

No se incluirá registro automático mediante EAN, QR u otros identificadores externos.

---

## Integración con catálogos externos

No se consultarán servicios externos para obtener información automática de productos.

---

## Gestión avanzada de usuarios y permisos

Todos los usuarios serán tratados inicialmente como `Miembro del hogar`.

---

## Conversión avanzada de unidades

Aunque el sistema utilizará tipos fuertemente tipados basados en VSlices, las conversiones complejas y compatibilidades avanzadas entre unidades quedan fuera del alcance inicial.

---

## Predicción de consumo

No se calcularán patrones automáticos de consumo ni estimaciones de duración futura.

---

# Preguntas abiertas

Las siguientes preguntas deberán resolverse en la vista lógica, porque afectan directamente el modelo de dominio.

## Sobre productos

* ¿Qué atributos deben ser obligatorios en Iteración 1?
> Hasta este momento, se consideran estos atributos con estas caracteristicas:
> - Nombre: Obligatorio, texto libre, maximo 100 caracteres.
> - Marca: Opcional, texto libre, maximo 50 caracteres.
> - Presentación: Opcional, texto libre, maximo 50 caracteres. 
>   - La presentación se refiere a la forma en que el producto se presenta o empaqueta, como "1 litro", "500 gramos", "pack de 6 unidades", etc.
> - Categoría: Opcional, texto libre, maximo 50 caracteres.
>   - Se diferencia con presentación en que la categoría se refiere a la clasificación general del producto, como "bebida", "lácteo", "limpieza", etc.
* ¿Qué define la identidad de un producto?
> El producto tendrá un ID autogenerado interno, pero también se considerará un producto equivalente si comparte los siguientes atributos: como nombre, marca, presentación y categoría.
* ¿Qué atributos diferencian dos productos aparentemente similares?
> Por ejemplo, dos productos con el mismo nombre pero diferente marca o presentación podrían ser considerados distintos.
* ¿Cómo se agruparán productos equivalentes?
> Podría ser útil agrupar productos equivalentes para simplificar la consulta y gestión, pero esto también podría complicar el modelo inicial.

---

## Sobre movimientos de inventario

* ¿Cómo se representará internamente un movimiento?
> Un movimiento es un registro que tiene las siguientes caracteristicas
> - Tipo: Entrada o salida
> - Producto asociado: Referencia al producto involucrado
> - Numerador: Cantidad de producto involucrada en el movimiento
> - Dimension: Unidad de medida
* ¿El stock actual será derivado o persistido?
> Para un integrante que ya este en el hogar, el stock es persistido, ya que ya tiene la versión anterior, pero para cuando se incorpore un nuevo integrante, el stock se derivará a partir de los movimientos registrados.
* ¿Cómo se garantizará consistencia entre movimientos y stock?
> La consistencia garantizará mediante reglas de negocio que aseguren que cada movimiento de entrada o salida actualice correctamente el stock disponible, evitando discrepancias.
> 
> Sin embargo, cuando se permita tener varios integrantes por hogar, dado que es inevitable que hay alguna descoordinación, cada movimiento incluirá un HASH generado mediante los datos del movimiento actual + los datos del movimiento anterior, lo que permitirá detectar cualquier inconsistencia o manipulación en la secuencia de movimientos, ya que cualquier cambio no autorizado en un movimiento alteraría el HASH de los movimientos posteriores.
> 
> En casos donde haya discrepancia, se tomará el HASH que sea mayoria en los integrantes del hogar, lo que permitirá mantener la integridad del inventario incluso en situaciones de descoordinación o manipulación. En casos donde no haya mayoria, se solicitará consenso entre los miembros del hogar para determinar el estado correcto del inventario.
* ¿Cómo evolucionarán las entradas y salidas hacia movimientos especializados?
> La tabla de movimientos ya de por si incluye un dato de "Tipo", cuando se agregue el concepto de "subtipos", primero los ya existentes tomaran el subtipo "Generico", y los que se crearan a futuro podran seleccionar entre ese y los que vendrna a futuro, como "Consumo", "Descarte", "Pérdida", "Ajuste manual", "Reposición", etc.

---

## Sobre bajo stock

* ¿Cómo evolucionará el modelo hacia reglas más avanzadas de suficiencia?
> En este momento, estas reglas aplican unicamente con producto, pero como se podrán aplicar a diferentes elementos, estas reglas de suficiencia deben especificarse de forma separada al producto en si, pero pudiendo hacer referente a este u otros elementos
> 
> Si bien internamente solo tendremos "Producto", el sistema podrá evaluar reglas de suficiencia que involucren otros conceptos, como resultados de analisis, siempre que se generen como un "objeto de reglas de suficiencia" (Lugar donde producto se especificará)

---

## Sobre arquitectura futura

* ¿Cómo evolucionará el sistema hacia múltiples hogares?
> El sistema en este momento generará un hogar por instalación, pero todos cualquier cambio que se realice, tanto en generación de ubicaciones, agregado de movimientos, agregado de productos tendrá un HASH asociado, siendo la primera acción la creación del hogar en sí
> 
> Cuando se incorpore un nuevo integrante al hogar, este podrá descargar el historial de acciones registradas hasta ese momento, lo que le permitirá tener una visión completa del hogar inventario desde su creación hasta su incorporación, pudiendo generar nuevas "acciones" las cuales se concatenarán con el HASH de la acción anterior para garantizar la consistencia del hogar.
> 
> Un hogar desaraprece cuando se borra el último integrante, lo que implica que el historial de acciones también se borra, pero si se desea conservar el historial, se podría implementar una función de exportación e importación antes de eliminar el hogar.
* ¿Cómo se integrarán ubicaciones explícitas posteriormente?
> Cada producto estará por si mismo, y un hogar podrá definir sus "ubicaciones" y cada ubicación crea un registro diferenciado entre ellas, pero compartidas en un "historial del hogar"
> 
> Esto cambia la definición que teniamos de "Movimiento", teniendo estos atributos
> - Tipo: Entrada o salida
> - Ubicación: Referencia de la ubicación especifica
> - Producto asociado: Referencia al producto involucrado
> - Numerador: Cantidad de producto involucrada en el movimiento
> - Dimension: Unidad de medida
* ¿Cómo evolucionará el sistema hacia trazabilidad visible para el usuario?
> En esta iteración, la trazabilidad se mantendrá principalmente a nivel de sistema, pero en futuras iteraciones se podrían incorporar vistas o reportes que permitan a los miembros del hogar revisar el historial de movimientos, entradas y salidas.

---

# Síntesis de la vista

La primera iteración del sistema reducirá el dominio a un conjunto mínimo de operaciones fundamentales sobre inventario:

* Consulta de disponibilidad.
* Entrada de inventario.
* Salida de inventario.
* Evaluación de bajo stock.

Esta simplificación busca construir primero un núcleo consistente, trazable y extensible antes de incorporar complejidades adicionales como ubicación, vencimiento, listas de compra o movimientos especializados.

El principio central del modelo es que el inventario cambia mediante movimientos.

Toda modificación relevante del stock deberá expresarse como una entrada o salida de inventario, permitiendo mantener consistencia, trazabilidad y evolución progresiva del dominio.

