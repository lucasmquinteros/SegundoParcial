Caso 1
Pregunta 1:
No, el texto especifica que no quiere guardar un historial de alquileres, aunque seria recomendable que si lo haga, ya que, si rompen o extravian algun producto saber quien fue.

Pregunta 2:
Si, es recomendable utilizar Lista o un Diccionario. Con un diccionario podria utilizar la llave de Tipo de Equipo y el valor seria una lista de los productos.
O utilizar una lista para evitar todo tipo de complejidad en el codigo y poder mantener simplicidad en el sistema.


Caso 2:
Pregunta 1:
Si, seria ineficiente cada vez que se inicia el sistema tener que agregar cada actividad devuelta. Luego aclara que no necesita reservas, ni historial asi que no hace falta guardar mas que cada actividad.

Pregunta 2:
No, no tendria llave para identificar cada actividad, o, si utilizara una lista no tendria ningun tipo de distincion a usar un diccionario siendo que cada nombre seria la llave.
Una lista podria ser util en este caso.


Caso 3:
Pregunta 1: 
Si, La llave seria el vuelo, y el valor seria una lista de pasajeros, cada vez que un pasajero saque un boleto para ese vuelo se agregaria en la lista.

Pregunta 2:
Si, Si pierdo los datos de una reserva cancelada, podria venir un cliente que haya sacado el boleto y no sabria reconocer si su reserva fue cancelado o no.


Caso 4:
Pregunta 1: 
No. Con persistir los datos de cada Cliente ya guardaria su historial de compras, y de esa forma podria calcular los puntos de fidelidad

Pregunta 2:
Si, Si no encapsulo, podrian suceder cambios en los datos de los clientes de forma imprevista, y entrarian en riesgo cosas importantes sobre cada cliente como su historial o puntaje de fidelidad.

Caso 5:
Pregunta 1:
Si, Seria util tener una enumeracion para conocer el tipo de dato ya que no hace falta mayor especifidad en cada tipo de vehiculo. Con una enumeracion alcanzará para saber sobre que vehiculo esta en cada lugar.

Pregunta 2:
No, en esta situacion nos especifican que no requiere de persistencia sobre un historial de vehiculos que hayan salido del Estacionamiento. Aunque tampoco seria util Guardar los datos de cada auto estacionado, por lo que persistencia en este caso no es aconsejable. 


Bonus:
Privado: Un atributo privado nos indica que solo la clase que implemente este estado de encapsulamiento será la unica capaz de Setear/Cambiar el atributo.

Protegido: Nos indica que solo las clases que hereden de nuestra clase padre podran setear/cambiar los atributos de mi clase. El resto no.

Publico: En este caso cualquier clase del sistema podria setear/Cambiar los atributos de esta clase.











--------------------------------------------------------------------------------------------------------------------------------------------
PAN <- Nombre - Precio - Categoria
INVENTARIO <- CRUD(Leer solo precios) - Lista<Panes> - Persistencia.
MENU <- CRUD - Lista<Acciones>
ENUM { PAN, BIZCOCHO, PASTEL }
