# Domum Orbis - Inventario del hogar

Domum Orbis es una aplicación orientada a la gestión consciente del inventario del hogar.

No busca ser una plataforma social.
No busca capturar atención.
No busca convertir datos en mercancía.

Busca algo más simple y más difícil: claridad.

Permite registrar productos, entender ciclos de consumo y reducir desperdicio, bajo una arquitectura pensada para ser autónoma, extensible y consistente con el dominio.

# Manifiesto

Domum Orbis nace de una idea simple: _el hogar es un sistema vivo_.

Cada compra, cada consumo, cada decisión cotidiana forma parte de un equilibrio. Cuando ese equilibrio se rompe, aparece el caos: olvidos, desperdicio, estrés innecesario.

Domum Orbis existe para reducir fricción, no para crear dependencia:

> No recolecta datos innecesarios. <br/>
  No monetiza la atención. <br/>
  No convierte el orden en ansiedad.

**Es una herramienta, no una distracción.**

Creemos que:

- El conocimiento reduce el desperdicio.
- La claridad reduce el estrés.
- La tecnología debe servir al hogar, no invadirlo.

Domum Orbis es offline-first porque la autonomía importa.

Es simple porque el tiempo es limitado.

Maneja el dominio con precisión porque los errores pequeños generan problemas grandes.

No busca maximizar _engagement_. Busca **maximizar** utilidad.

No premia la _obsesión_. Promueve la **conciencia**.

El hogar no es una base de datos. Pero entenderlo mejor nos ayuda a cuidarlo mejor.

***Domum Orbis* es orden sin ruido.**

# Principios tecnicos

El diseño del sistema se basa en:

- Arquitectura orientada a dominio (Domain-Driven Design).
- Persistencia basada en eventos para mantener trazabilidad.
- Modelo extensible mediante enriquecimiento de tipos de dominio.
- Enfoque offline-first como prioridad estructural.
- Separación clara entre dominio, aplicación e infraestructura.
- Costo de operación cercano a cero para mantener accesibilidad.

Las decisiones técnicas **deben ser coherentes con el manifiesto**.

> Si una funcionalidad contradice estos principios, se reconsidera

# Stack técnico

- NET (C#)
- Arquitectura modular
- Persistencia event-driven
- Enfoque preparado para futura sincronización distribuida
- Publicación objetivo: Android (Google Play)

# Estado actual 

Experimental.

El MVP se encuentra en desarrollo con foco en:
- Modelo de dominio sólido
- Persistencia local
- Funcionalidades base de inventario
- Preparación para extensiones futuras