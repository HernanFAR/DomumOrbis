# Escenario de trabajo:
Flujo de gestión de inventario del hogar

## Objetivo:
Describir cómo ocurre la gestión de inventario en un uso cotidiano sin aplicación, identificando acciones reales, decisiones informales y problemas derivados de la falta de trazabilidad, visibilidad y control.

## Actores principales

### Miembro del hogar

Puede ser cualquier persona que vive en la casa o participa en la administración del hogar.

En el flujo cotidiano sin aplicación, este actor no necesariamente tiene un rol formal. Puede ser quien cocina, quien compra, quien limpia, quien revisa la despensa o quien simplemente usa un producto.

Sus acciones suelen ser manuales, reactivas y basadas en memoria, observación directa o costumbre.

# Flujos del escenario

## Consulta de inventario
### Desencadenante

Un miembro del hogar requiere saber la disponibilidad de un producto en el inventario.

Ejemplos:

```text
¿Queda arroz?
¿Hay leche?
¿Tenemos detergente?
¿Dónde están las pilas?
¿Queda comida para la mascota?
```

### Acciones

* El miembro del hogar piensa en el producto que necesita.
* Recuerda o asume una ubicación probable.
* Se dirige a una o más ubicaciones del hogar.
* Revisa visualmente si el producto existe.
* Si no lo encuentra, revisa otras ubicaciones posibles.
* Si lo encuentra, estima si la cantidad disponible es suficiente.
* Decide si puede usarlo, comprar más o avisar a otra persona.

Ejemplo cotidiano:

```text
Una persona quiere cocinar arroz.
Va a la despensa.
Ve una bolsa abierta.
La levanta para estimar cuánto queda.
Si cree que alcanza, la usa.
Si cree que queda poco, mentalmente anota que hay que comprar más.
```

### Problemáticas encontradas

#### 1. La disponibilidad depende de revisar físicamente

Sin una aplicación o registro, saber si existe un producto exige ir físicamente a buscarlo.

Esto genera fricción porque la consulta no es inmediata. La persona debe interrumpir lo que está haciendo, moverse hasta la ubicación y revisar manualmente.

Problema típico:

```text
La persona está en el supermercado y no sabe si queda aceite en casa.
Como no tiene visibilidad remota, compra “por si acaso” o no compra y se arriesga.
```

---

#### 2. El inventario real está distribuido en varias ubicaciones

Un mismo producto puede estar en distintos lugares:

```text
Despensa
Refrigerador
Congelador
Baño
Bodega
Lavandería
Cocina
Dormitorio
```

Esto hace que una consulta simple pueda transformarse en una búsqueda por toda la casa.

Problema típico:

```text
Se cree que no hay papel higiénico porque no está en el baño,
pero en realidad hay más unidades guardadas en la bodega.
```

---

#### 3. La ubicación esperada puede no coincidir con la ubicación real

Las personas no siempre guardan los productos en el mismo lugar. Alguien puede mover un producto sin avisar o dejarlo en una ubicación temporal.

Problema típico:

```text
El detergente debería estar en la lavandería,
pero alguien lo dejó en la cocina después de limpiar.
Otra persona lo busca en la lavandería y asume que no queda.
```

---

#### 4. La cantidad disponible se estima de forma imprecisa

En muchos casos, la persona no mide exactamente cuánto queda. Solo estima visualmente.

Ejemplos:

```text
Queda “un poco” de arroz.
Queda “media botella” de aceite.
Quedan “como dos lavados” de detergente.
Queda “casi nada”.
```

Esto puede ser suficiente para decisiones rápidas, pero es poco confiable para planificar.

Problema típico:

```text
La persona cree que queda suficiente café para la semana,
pero al día siguiente se acaba.
```

---

#### 5. No existe una definición clara de “suficiente”

La suficiencia depende del criterio del miembro del hogar.

Para una persona, dos unidades pueden ser suficientes. Para otra, puede ser bajo stock.

Ejemplo:

```text
Quedan 2 litros de leche.
Una persona piensa que alcanza.
Otra sabe que la familia consume 1 litro diario y considera que hay que comprar.
```

Sin reglas explícitas, cada consulta depende de intuición, costumbre o memoria.

---

#### 6. La información puede quedar en la memoria de una sola persona

Muchas veces una persona sabe qué hay, dónde está y cuánto queda, pero esa información no está compartida.

Problema típico:

```text
Solo una persona sabe que hay arroz guardado en la bodega.
Otra persona revisa la despensa, no lo encuentra y compra más.
```

Esto genera dependencia de conocimiento informal.

---

#### 7. Se producen compras duplicadas

Cuando no hay certeza sobre la existencia de un producto, el miembro del hogar puede comprar nuevamente para evitar quedarse sin stock.

Problema típico:

```text
Se compran tres paquetes de sal porque varias personas pensaron que no había.
Después aparecen paquetes antiguos en distintas ubicaciones.
```

---

#### 8. Se pueden pasar por alto productos próximos a vencer

Durante una consulta rápida, la persona suele revisar existencia, no necesariamente fecha de vencimiento.

Problema típico:

```text
Hay yogures en el refrigerador, pero nadie revisa que vencen mañana.
Se compra más yogur nuevo y los antiguos terminan perdiéndose.
```

---

#### 9. La búsqueda consume tiempo y atención

Buscar productos en varias ubicaciones puede ser lento, especialmente si el hogar tiene muchas categorías de productos.

Problema típico:

```text
Antes de cocinar, la persona pierde varios minutos buscando ingredientes.
Encuentra algunos, no encuentra otros y debe cambiar el plan.
```

---

## Reposición de productos
### Desencadenante

Al realizar una consulta de inventario, el miembro detecta que no hay existencias del producto que intentó buscar o que las existencias no son suficientes para una cantidad de días determinada según su propio criterio.

También puede desencadenarse por:

* Planificación de compras.
* Rutina semanal o mensual.
* Promociones.
* Necesidad urgente.
* Producto agotado durante el consumo.
* Recordatorio informal de otro miembro del hogar.

Ejemplos:

```text
No queda arroz.
Queda poco aceite.
Falta detergente.
La comida de la mascota alcanza solo para dos días.
Hay una oferta y se decide comprar más.
```

### Acciones

* El miembro del hogar identifica que debe comprar uno o más productos.
* Puede anotarlo mentalmente, en papel, en una app genérica o comunicarlo verbalmente.
* Se realiza la compra.
* Los productos llegan al hogar.
* Se guardan en una o varias ubicaciones.
* En algunos casos se reorganizan productos existentes.
* En algunos casos se mezclan productos nuevos con productos antiguos.
* La información sobre la reposición queda implícita en la ubicación física.

Ejemplo cotidiano:

```text
Una persona nota que queda poca pasta.
Al ir al supermercado compra dos paquetes.
Al llegar a casa, los guarda en la despensa.
No actualiza ningún registro formal.
```

### Problemáticas encontradas

#### 1. La necesidad de compra puede olvidarse

Si la detección de bajo stock no se registra de inmediato, depende de la memoria del miembro del hogar.

Problema típico:

```text
La persona nota que queda poco detergente,
pero no lo anota.
Cuando va al supermercado, se le olvida comprarlo.
```

---

#### 2. La lista de compras puede quedar incompleta

Cuando las necesidades se detectan en distintos momentos, por distintas personas y en distintas ubicaciones, es común que no se consoliden.

Problema típico:

```text
Una persona nota que falta arroz.
Otra nota que falta jabón.
Otra nota que falta alimento para la mascota.
Pero nadie arma una lista única.
```

---

#### 3. Se compra de más por incertidumbre

Ante la duda, el miembro puede comprar más de lo necesario.

Esto reduce el riesgo de quedarse sin producto, pero aumenta sobrestock, gasto y desorden.

Problema típico:

```text
No se sabe si queda papel absorbente.
Se compra otro paquete grande.
Al llegar a casa, ya había dos paquetes guardados.
```

---

#### 4. Se compra de menos por mala estimación

También puede ocurrir lo contrario: la persona cree que hay suficiente stock o compra poca cantidad.

Problema típico:

```text
Se compra solo una leche porque parecía que quedaban varias.
Al día siguiente se descubre que la mayoría ya estaba abierta o vencida.
```

---

#### 5. Los productos pueden guardarse en ubicaciones inconsistentes

Al llegar con compras, los productos se guardan donde haya espacio, no necesariamente donde corresponde.

Problema típico:

```text
Parte de la compra queda en la despensa,
otra parte en la bodega,
y algunos productos quedan temporalmente sobre la mesa.
Después nadie recuerda dónde quedó cada cosa.
```

---

#### 6. No queda registro de fecha de ingreso

En productos perecibles, saber cuándo entraron al hogar puede ser importante.

Sin registro, solo queda mirar la fecha de vencimiento o confiar en memoria.

Problema típico:

```text
Hay dos paquetes de jamón.
Uno fue comprado antes y vence primero,
pero se usa el nuevo porque quedó más visible.
El antiguo se pierde.
```

---

#### 7. No se respeta necesariamente FIFO/FEFO

En inventario doméstico real, la gente suele usar lo que está más a mano, no lo más antiguo ni lo que vence primero.

```text
FIFO: First In, First Out.
FEFO: First Expired, First Out.
```

Problema típico:

```text
Se abre una leche nueva mientras otra más antigua sigue al fondo del refrigerador.
```

---

#### 8. Los productos nuevos pueden duplicar productos existentes

Cuando no se sabe que un producto ya existe en otra ubicación, la compra genera duplicados.

Problema típico:

```text
Se compra ketchup porque no estaba en el refrigerador.
Luego aparece una botella cerrada en la despensa.
```

---

#### 9. No hay trazabilidad de quién repuso qué

En general no importa saber quién compró algo, hasta que hay confusión o coordinación familiar.

Problema típico:

```text
Dos personas compran el mismo producto el mismo día
porque ambas creían que nadie lo había repuesto.
```

---
#### 10. El inventario queda actualizado físicamente, pero no cognitivamente

El producto existe en la casa, pero los demás miembros no necesariamente lo saben.

Problema típico:

```text
Alguien compró café y lo guardó.
Otro miembro no lo sabe y compra más al día siguiente.
```

Esta frase podría quedar bonita en la documentación:

```text
En el flujo manual, la reposición actualiza el inventario físico,
pero no necesariamente actualiza el conocimiento compartido del hogar.
```

---

## Consumo/uso de inventario

### Desencadenante

El miembro del hogar consume o usa un producto para cumplir un objetivo específico.

Ejemplos:

```text
Cocinar una comida.
Limpiar una habitación.
Lavar ropa.
Alimentar una mascota.
Tomar un medicamento.
Usar un repuesto.
Realizar una reparación doméstica.
```

### Acciones

* El miembro identifica el producto que necesita.
* Se dirige a una ubicación probable.
* Toma uno o varios productos.
* Usa una parte o la totalidad del producto.
* Puede devolver un remanente a la misma ubicación o a otra.
* Puede desechar el envase vacío.
* Puede notar que queda poco o que se agotó.
* Puede avisar, anotar o simplemente recordar que hay que reponer.

Ejemplo cotidiano:

```text
Una persona prepara panqueques.
Usa harina, leche, huevos y aceite.
La leche se acaba.
La harina queda casi vacía.
La persona sigue cocinando y puede olvidar avisar que hay que comprar más.
```

### Problemáticas encontradas

#### 1. El consumo no queda registrado

El inventario cambia, pero no existe una evidencia formal del cambio.

Problema típico:

```text
Ayer había 1 kg de arroz.
Hoy alguien usó la mitad.
Nadie más lo sabe hasta que vuelve a revisar físicamente.
```

---

#### 2. Otros miembros mantienen una visión desactualizada

Como el uso no se comunica automáticamente, otra persona puede seguir creyendo que el producto está disponible.

Problema típico:

```text
Una persona usa el último huevo.
Otra persona intenta cocinar más tarde y descubre recién ahí que no quedan.
```

---

#### 3. El producto puede agotarse sin aviso

El consumo suele ocurrir mientras la persona está enfocada en otra tarea. Detectar y comunicar agotamiento queda como responsabilidad secundaria.

Problema típico:

```text
Se termina el detergente mientras alguien lava ropa.
La persona bota el envase y olvida avisar.
El problema reaparece en el siguiente lavado.
```

---

#### 4. El remanente puede quedar en una ubicación distinta

Después del uso, el producto puede no volver a su ubicación original.

Problema típico:

```text
Se usa la sal para cocinar y queda sobre la mesa.
Después alguien la busca en la despensa y cree que no hay.
```

---

#### 5. La cantidad restante puede ser difícil de medir

Algunos productos no se consumen en unidades discretas.

Ejemplos:

```text
Aceite
Harina
Arroz
Detergente líquido
Shampoo
Gas
Comida de mascota
```

Problema típico:

```text
Queda “un poco” de aceite,
pero nadie sabe si alcanza para una semana o para una comida más.
```

---

#### 6. Se puede consumir sin considerar vencimiento

El usuario puede tomar el producto más visible, no necesariamente el que vence antes.

Problema típico:

```text
Se usa una salsa nueva porque está adelante.
La salsa antigua queda atrás y vence.
```

---

#### 7. Puede haber consumo parcial sin cierre claro

A veces un producto queda abierto, a medias, sin estado claro.

Problema típico:

```text
Hay tres bolsas de arroz abiertas con pequeñas cantidades.
Nadie sabe cuánto hay en total ni cuál debería usarse primero.
```

---

#### 8. Puede haber desperdicio no registrado

El producto puede perderse por vencimiento, daño, caída, contaminación o mal almacenamiento.

Problema típico:

```text
Se derrama medio litro de leche.
El stock real disminuye, pero nadie lo considera como parte del inventario.
```

---

#### 9. El consumo puede revelar problemas demasiado tarde

Muchas veces se descubre que falta algo justo cuando se necesita.

Problema típico:

```text
La persona empieza a cocinar y recién ahí nota que no hay aceite.
Ya no es una planificación, es una urgencia.
```

---

#### 10. No se conecta automáticamente con una acción de reposición

Aunque alguien detecte que un producto se agotó, esa información no siempre se convierte en compra.

Problema típico:

```text
Se acaba el café.
Alguien piensa “hay que comprar”.
Nadie lo anota.
Pasan dos días sin café.
Tragedia doméstica, básicamente.
```

Esta también puede quedar como frase de documentación:

```text
En el flujo manual, el consumo modifica el inventario real,
pero la necesidad de reposición depende de memoria, comunicación informal
o revisión física posterior.
```

---

# Lectura general del escenario

En la gestión manual del inventario del hogar, el estado del inventario existe principalmente como una combinación de ubicación física, memoria individual y comunicación informal.
- Cada consulta requiere inspección física.
- Cada reposición actualiza el inventario real, pero no necesariamente el conocimiento compartido. 
- Cada consumo reduce el stock, pero rara vez deja trazabilidad.

Esto provoca problemas de visibilidad, duplicidad, olvido, sobrecompra, quiebres de stock, pérdida de productos por vencimiento y decisiones basadas en estimaciones imprecisas.

## Problemas transversales

### 1. Falta de visibilidad

No se sabe qué existe sin revisar físicamente.

### 2. Falta de trazabilidad

No queda registro claro de entradas, salidas, ajustes o pérdidas.

### 3. Dependencia de memoria

El sistema manual depende de que alguien recuerde qué falta, qué se compró y dónde se guardó.

### 4. Conocimiento fragmentado

Distintos miembros tienen información parcial.

### 5. Baja coordinación entre miembros

Varias personas pueden comprar, usar o mover productos sin que las demás lo sepan.

### 6. Estimaciones imprecisas

Las cantidades suelen expresarse como “queda poco”, “queda harto” o “alcanza”, no como datos verificables.

###	7. Desorden por ubicaciones múltiples

Los productos pueden estar duplicados o distribuidos en lugares no evidentes.

### 8. Riesgo de vencimiento o desperdicio

La gestión manual no prioriza automáticamente productos próximos a vencer.

### 9. Ruptura de stock

La falta se detecta cuando el producto ya se necesita.

### 10. Sobrestock

Se compra de más para compensar la incertidumbre.
