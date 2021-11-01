# Título El Ciber De Lalo
*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)

## Sobre mí
Mi nombre es Gonzalo, tengo 21 años y arranque a programar a mitad del año pasado y la verdad que me encanto todo el mundo de la programacion, al principio me costo mucho poder entender como escribir los codigos y lograr hacer los algoritmos, pero despues pude encontrarle la forma de hacerlos y me impulso a seguir estudiando. A veces me trabo con algun problema del codigo pero eso siempre me impulsa a buscar por otro lado que no sea en la facultad, y trato de resolverlos. Este parcial me parecio al principio, masomenos facil, pero cuando lo entre a plantear mucho mejor ahi vinieron los problemas, es un trabajo bastante extenso y complicado, pero me gusto muchisimo la idea de poder tener la libertad de hacerlo como quiera cada uno

## Resumen
El programa tiene el objetivo de cumplir con las tareas comunes de un simple ciber. Cuenta con cabinas telefonicas para hacer llamadas tanto locales,larga distancia e internacionales, como tambien cuenta con computadoras para jugar juegos,chatear o simplemente buscar informacion. Se pueden consultar estadisticas, como clientes en espera, los puestos que estan cargados actualmente entre otras cosas.

## Diagrama de clases


## Justificación técnica
Utilize metodos  y clases abstractas para poder tener uso de estos sin tener la necesidad de instanciarlos, ya que el manejo o funcionalidad de estas, estan pensadas para realizar acciones sin instancia.
Se utilizo Herencia para poder crear tres clases bases, una de Sesion que la heredan Llamada y Conexion, ya que en Sesion guardo los datos necesarios del cliente,puesto a usar , el horario de inicio y final. 

La otra clase base es Cliente que guarda tanto nombre,apellido,documento y dni de este, y las derivan las clases Clientecomputadora y ClienteCabina, lo maneje en clases separadas ya que comparten los mismos campos de un cliente pero las especificacion son muy distintas, entonces al separarlas es un manejo mucho mas comodo. 

Y por ultimo, la clase Puesto que guarda el estado del puesto,la cantidad de minutos de uso y un ID, a esta clase la derivan Cabina y Computadora, lo mismo, ya que comparten los mismos campos era necesario realizar la herencia para no repetir codigo. Cabina lo que guarda es el tipo y marca del telefono y un ID, en cambio Computadora guardar listas de especificaciones sobre la misma.

Se encapsularon tanto funciones como atributos para un manejo mucho mas seguro del codigo, ya que solo se dejo en publico las funciones que eran necesarias para realizar algun calculo o demas.

Se realizaron sobrescrituras de metodos ya que necesitaba devolver datos de las clases y para no escribir la misma funcion o con nombre diferente en cada clase, se sobrescribio el metodo ToString

Las colecciones que se manejaron en este parcial son las List y las Queue, las List se utilizaron para poder guardar todos los puestos guardados, las sesiones creadas, las especificaciones de las computadoras, etc. Y las Queue para guardar los clientes asignados, ya que se tenia que manejar por orden de llegada, entonces se decidio por estas listas ya que se ordenan de forma FIFO (primero en entrar, primero en salir) 

Todo el parcial esta hecho en formularios (14 para ser mas exacto), se trato de buscar la mejor manera de realizarlos y que el cliente se sienta comodo al utilizarlos y que se entiendan bien, con esto se manejo carteles de aviso por cualquier error para poder decirle al usuario que estaba ingresando mal los datos.

Por ultimo agrege el indexador del tipo Sesion con la propiedad de lectura solamente en la clase Controlador, esto me sirvio para poder listar en los distintos formularios las sesiones que estaban activas.

Tambien le agregue la funcionalidad de asignacion de minutos de duracion a la Conexion de Cliente y Computadora, esto permite que el administrador ingrese el tiempo solicitado y se le cobre el costo final de la sesion.

Utilize sobrecarga de constructores para el hardcodeo de las computadoras.

Clase sellada Controlador, maneja las acciones que se van a realizar en los distintos formularios. 
Esta clase es la unica que no tiene sobrescrito el metodo Equals ni el GetHashCode, ya que no tiene ningun dato ni identificador como para devolver en el GetHashCode.
El Equals no se sobrescribe ya que esta clase es unica y no se va a tener que comparar con otra de su mismo tipo, ya que su unica funcion es controlar la interfaz de usuario e ir 
administrando las acciones que solicita el usuario.

## Propuesta de valor agregado
La propuesto de valor que agregue fue realizar un ABM (Alta - Baja - Modificacion) de los dos puesto, tanto para las cabinas como para las computadoras, se maneja, a la hora de dar de alta el puestom la cantidad limite de las cabinas (5) y la cantidad limite de las computadoras (10). Se pueden modificar todos los campos menos el ID ya que no tendria sentido modificarlo. A la hora de borrar, se elimina el puesto de la lista. El Modificar y el Borrar, se maneja todo como el identificador del puesto, se busca en la lista de Puestos y si es correcto el identificador, sigue con la accion a realizar.