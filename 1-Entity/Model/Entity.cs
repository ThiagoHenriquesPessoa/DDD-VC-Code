using System;
 namespace Model{
     public class Entity{
         public Guid Id {get; set;}
         public Entity(){
             Id = Guid.NewGuid();
         }
     }
 }