# Noche de Calabazas

## Ficha técnica

### Estudiante o integrantes

- **Estudiante/integrante:** Miguel isaac Burgos
- **Modalidad:** Individual


### Temática y misión

Experiencia de realidad virtual ambientada en un cementerio durante la noche de Halloween. El jugador debe explorar el escenario y activar las tres calabazas `Pumpkin_Torch_1`, `Pumpkin_Torch_2` y `Pumpkin_Torch_3`.

La misión consiste en:

1. Encontrar y encender las tres calabazas mediante la mirada.
2. Desbloquear el portal del cementerio.
3. Atravesar el portal y continuar hacia la zona final.

### Zonas y acciones

#### Zona 1: Cementerio de Halloween

Es la zona inicial del recorrido. Contiene el escenario del cementerio, las tres calabazas interactivas y el portal de piedra (`GraveStonePortal`).

**Acción 1 — Encender las calabazas:**  
El jugador debe mirar cada `Pumpkin_Torch_X` durante el tiempo de permanencia configurado. Al completar la interacción, se enciende su luz y se registra su activación. Cada calabaza solo puede activarse una vez.

#### Zona 2: Zona final / Last Pumpkin

Es la zona posterior al portal, asociada al objeto `LastPumpkin` y al punto de destino `TP_Point`.

**Acción 2 — Activar el portal y teletransportarse:**  
Cuando las tres calabazas están encendidas, `GraveStonePortal` permite transportar al jugador desde el `XRRig` hasta el destino configurado. En la zona final, `PumpkinOff` puede apagar la luz asociada y desactivar el objeto `LastPumpkin`.

> Si la pauta exige un nombre distinto para la segunda zona, reemplazar “Zona final / Last Pumpkin” por el nombre definido para la experiencia.

### Flujo del recorrido

1. Iniciar la experiencia en la escena `FirstScene`.
2. Observar el entorno mediante el visor de realidad virtual.
3. Apuntar la mirada hacia `Pumpkin_Torch_1`, `Pumpkin_Torch_2` y `Pumpkin_Torch_3`.
4. Mantener la mirada hasta completar la barra de permanencia de cada objeto.
5. Confirmar que las tres luces estén encendidas.
6. Mirar el objeto `GraveStonePortal`.
7. El portal permanece bloqueado mientras no se hayan activado las tres calabazas.
8. Al completar la condición, el jugador es teletransportado a `TP_Point`.
9. Continuar la interacción en la zona final y completar la experiencia.

## Requisitos e instrucciones de ejecución

### Requisitos

- Unity **6000.6.0f1**.
- Soporte de Android instalado mediante Unity Hub.
- Dispositivo Android compatible con la experiencia de realidad virtual.
- Visor compatible con Google Cardboard o el modo de simulación disponible en el proyecto.

### Ejecución en Unity

1. Abrir Unity Hub.
2. Seleccionar **Add** y elegir la carpeta raíz del proyecto `Noche de Calabazas`.
3. Abrir el proyecto con Unity `6000.6.0f1`.
4. Abrir la escena `Assets/Scenes/FirstScene.unity`.
5. Presionar **Play**.
6. Utilizar la mirada y la barra de permanencia para interactuar con las calabazas y el portal.

### Ejecución en Android

1. Abrir **File > Build Profiles**.
2. Seleccionar Android como plataforma de destino.
3. Confirmar que `FirstScene` esté incluida en las escenas de la compilación.
4. Conectar el dispositivo Android con la depuración USB habilitada.
5. Seleccionar **Build And Run**.
6. Iniciar la aplicación con el dispositivo insertado en el visor compatible.

## Fuentes y licencias de los assets

- **Google Cardboard XR Plugin:** utilizado para la interacción de realidad virtual mediante mirada. Fuente: repositorio oficial de Google Cardboard XR Plugin. Licencia: revisar la licencia incluida por el paquete en `Packages` o en su repositorio oficial.
- [**Halloween Cemetery Set:**](https://assetstore.unity.com/packages/3d/environments/fantasy/halloween-cemetery-set-19125) paquete utilizado para modelos y elementos visuales del cementerio y las calabazas. Fuente: paquete incluido en `Assets/cemetery halloween set`. Licencia: Standart Unity Asset Store EULA.
- **TextMesh Pro / Liberation Sans:** recursos tipográficos incluidos en el proyecto. El archivo de licencia se encuentra en `Assets/TextMesh Pro/Fonts/LiberationSans - OFL.txt`. Licencia: SIL Open Font License.
- **Unity y paquetes oficiales:** Unity, Input System, UGUI, XR y demás paquetes se utilizan bajo sus respectivas licencias de Unity y de los proveedores correspondientes.
- **Assets propios:** scripts de interacción y lógica del proyecto, ubicados principalmente en `Assets/Scripts`.

No se deben redistribuir assets de terceros fuera de los términos de sus respectivas licencias.

## Declaración de uso de IA

IA Artificial generativa (Github Copilot) fue usada en este proyecto, principalmente para la ayuda del arreglo de Errores salidos en el desarrollo. Todo el Codigo entregada por esta fue revisado antes de ser implementado y adaptado en caso de ser necesario para su correcto funcionamiento. A su par, me apoye de IA Generativa para generar el README a excepción de este apartado. 

## Estado de la prueba en Android

- **Dispositivo utilizado:** Vivo V40Se
- **Versión de Android:** Ultima hasta la fecha
- **Resultado de la prueba:** Aprobada
- **Fecha de prueba:** 27-10-2026
- **Observaciones:** Es complejo usar los canvas, se rompen por todo.

