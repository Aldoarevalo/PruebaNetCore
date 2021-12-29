# PruebaNetCore

1. Para ejecutar el proyecto descargue o clone el proyecto

2. Luego de descargar abra el proyecto con visual studio y ejecute compilar o  desde la linea de comandos dotnet run

3.luego se abrirá el navegador con esta dirección https://localhost:44354/swagger la base de datos utilizada para este tutorial es InMemory

4. en el navegador podrás cargar una transferencia desde el metodo post de swagger

![image](https://user-images.githubusercontent.com/57592844/147657859-65e98edc-b7f5-4fad-bbe3-1f79e8900992.png)
![image](https://user-images.githubusercontent.com/57592844/147657952-b5ed3927-a25b-4f3e-b348-0a11e5d4c2aa.png)

5. si cargamos el proyecto con una cuenta de origen y destino iguales el sistema lanzará una excepción como se ve a continuación

![image](https://user-images.githubusercontent.com/57592844/147658187-3661db86-99cf-4e97-98d2-d2ca66e7c030.png)
![image](https://user-images.githubusercontent.com/57592844/147658251-af3860b2-aeed-49d7-a33c-a4e6bf4e1fda.png)

6. el banco de origen debe poseer fondos de lo contrario se lanzará excepción 

![image](https://user-images.githubusercontent.com/57592844/147658939-11aa4282-7862-4442-af3e-aa40922f6ff9.png)
![image](https://user-images.githubusercontent.com/57592844/147658974-d72203b9-7dce-4ee6-8a6e-febcd248c8f5.png)

7 se podrá consultar el historial de todas las transferencias por medio del metodo get

![image](https://user-images.githubusercontent.com/57592844/147659229-874aeddd-9df7-481f-be95-acaf990f4369.png)

8. Se podrá filtrar una transferencia por número de operación

![image](https://user-images.githubusercontent.com/57592844/147659326-a197c69d-96ff-4cf9-be48-2690b8b0121d.png)

9. colecciónes generadas en postman

9.1. Metodos post y get en colección postman de las transferencias

https://www.getpostman.com/collections/4a24cfe33d7f4ff7f55e

10. la documentación de la api generada en postman se encuentra en el siguiente link

https://documenter.getpostman.com/view/17744238/UVRGEPRy









