---

id: improvement.solution
type: [improvement]
status: active
scope: stage
related:

* details from [proposal.solution](proposal.solution.md)
* will improve [process.household-shopping](../contextualizing/process.household-shopping.md)
* uses [vocabulary.domain](../vocabulary.domain.md)
* is contained by [scope.iteration](../understanding/scope.iteration.md)

---

# Mejoras futuras de la solución

## Nota

Este documento registra mejoras posibles para una siguiente iteración/sprint.

La solución actual propone crear un archivo YAML centralizado para registrar mercados y productos de compra. Esa solución busca reducir la fricción inmediata de la compra mensual sin resolver todavía automatización completa, pagos, inventario o integración definitiva con un mercado.

Las mejoras descritas acá no forman parte obligatoria de la entrega actual. Su objetivo es preservar oportunidades futuras sin aumentar el alcance de esta iteración.

## Contexto

Durante Planning se propuso una solución pequeña: mantener una lista mensual de compra en un archivo YAML.

El archivo inicial permite registrar:

* mercados
* URL base del mercado
* productos
* enlaces de producto
* cantidades
* peso cuando corresponda

Esto permite que la intención de compra mensual exista fuera del carrito de una tienda específica. También evita depender únicamente de compras anteriores, memoria humana o reconstrucción manual después del pago.

Sin embargo, al definir esta solución aparecieron posibles mejoras que podrían volver la lista más útil, más segura o más fácil de usar en siguientes iteraciones.

## Por qué importa

Estas mejoras importan porque la solución rápida no debe ser desechable.

Aunque la primera versión sea pequeña, el formato debe poder crecer hacia una solución más completa sin perder la intención original: preparar la compra mensual antes del pago y reducir la carga ejecutiva del proceso.

Registrar estas mejoras permite separar tres cosas:

* lo que se resolverá ahora;
* lo que se sabe que puede mejorar después;
* lo que todavía no conviene implementar.

Esto evita que la solución inicial crezca demasiado pronto, pero también evita perder ideas relevantes para la evolución de Domus Orbis.

## Mejoras posibles

### Validar el formato YAML

Agregar una validación básica del archivo para detectar errores antes de usarlo.

Posibles validaciones:

* `version` debe existir.
* `mercados` debe contener al menos un mercado.
* cada mercado debe tener `nombre`, `urlBase` y `productos`.
* cada producto debe tener `nombre` y `url`.
* cada producto debe tener `cantidad` o `peso`.
* un producto no debería tener `cantidad` y `peso` al mismo tiempo.

### Definir unidad de peso

La primera versión usa `peso` como número simple.

En una siguiente iteración puede ser necesario agregar unidad para evitar ambigüedad.

Ejemplo:

```yaml
peso:
  valor: 1.5
  unidad: kg
```

Esto permitiría distinguir kilos, gramos u otra unidad usada por el mercado.

### Agregar notas por producto

Permitir notas simples para productos que requieren cuidado humano.

Ejemplo:

```yaml
productos:
  - nombre: Plátano
    url: https://sample.cl/producto/platano
    peso: 1.5
    nota: Comprar maduro, pero no demasiado blando.
```

Esta mejora no debería convertirse todavía en reglas complejas de sustitución.

### Separar productos esenciales y opcionales

Agregar una forma simple de marcar prioridad.

Ejemplo:

```yaml
productos:
  - nombre: Arroz
    url: https://sample.cl/producto/arroz
    cantidad: 2
    prioridad: esencial
```

Esto ayudaría a proteger productos importantes si hay poco tiempo, poca energía o presupuesto limitado.

### Generar una vista humana de la lista

Crear una salida legible a partir del YAML.

Por ejemplo:

* imprimir lista en consola;
* generar Markdown;
* generar resumen por mercado;
* mostrar enlaces y cantidades.

Esto permitiría usar la lista sin depender todavía de automatización de carrito.

### Preparar carrito de forma asistida

Crear una herramienta que lea el YAML y ayude a abrir productos del mercado para agregarlos manualmente.

Esto podría ser un paso intermedio antes de Playwright.

La herramienta podría:

* abrir los enlaces de productos;
* mostrar cantidades esperadas;
* guiar la compra producto por producto.

### Automatizar preparación de carrito

Usar Playwright u otra integración para preparar el carrito automáticamente a partir del archivo YAML.

Esta mejora debería implementarse solo después de validar que el archivo centralizado realmente reduce la fricción del proceso mensual.

Debe considerarse frágil si depende de la estructura visual del sitio del mercado.

### Soportar múltiples mercados de forma real

La primera estructura permite más de un mercado, pero eso no significa que el sistema ya soporte múltiples mercados de forma completa.

Una mejora futura podría definir cómo dividir productos entre mercados, cómo revisar listas separadas y cómo evitar duplicados.

### Registrar lista como pagada

Permitir marcar que una lista mensual ya fue pagada.

Esto no significa ejecutar el pago. Solo registra que la compra ya ocurrió.

Esta mejora puede cerrar el ciclo del proceso:

* lista preparada;
* compra realizada;
* lista marcada como pagada.

### Pagar una lista

Permitir que el sistema ejecute o asista el pago de una lista.

Esta mejora tiene mayor riesgo porque involucra dinero, métodos de pago, confirmaciones, errores externos y posibles estados inconsistentes.

No debería implementarse antes de validar los pasos anteriores.

## Fuera de alcance de estas mejoras

Estas mejoras no implican todavía:

* construir una aplicación completa;
* administrar inventario del hogar;
* comparar precios;
* resolver sustituciones complejas;
* automatizar pagos;
* asumir que Líder será el único mercado;
* convertir el YAML en un modelo definitivo del dominio.

## Siguiente acción

1. Crear el primer archivo de compra mensual usando YAML. 
2. Hacer entrega del artifact al cliente.
3. Registrar notas de validación post-entrega.
4. Elegir una mejora pequeña para el siguiente sprint.
