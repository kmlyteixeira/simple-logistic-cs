# simple-logistic-cs



```csharp
======== MODELAGEM ========
--------------------              --------------------               --------------------
---   CAMINHAO   ---              ---     ROTA     ---               ---    CIDADE    ---                
--- * id         --- -----------> ---  * id        --- <-----------  --- * id         ---      
--- * placa      ---              ---  * data      --- <-----------  --- * nome       ---       
--- * motorista  ---              ---  * partida   ---               --------------------           
--------------------              ---  * chegada   ---
                                  ---  * caminhao  ---
                                  --------------------

simple-logistic-cs
|
├── Controller
│   ├── Caminhao.cs
│   ├── Cidade.cs
│   └── Rota.cs
|  
├── Model
│   ├── Caminhao.cs
│   ├── Cidade.cs
│   └── Rota.cs 
|
├── View
|   ├── Menu.cs
│   ├── Caminhao.cs
│   ├── Cidade.cs
│   └── Rota.cs
|
├── Utils.cs
├── Program.cs
|
└ README.md
```
