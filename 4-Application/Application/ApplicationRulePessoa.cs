using System;
namespace Application{
    public class ApplicationRulesPessoa : IAppliclationRulesPessoa{
        public Task<List<Pessoa>> GetAll(string search = null){

        }
        public bool Add(Pessoa pessoa){
            if(pessoa == null || pessoa.Nome == null || pessoa.Documento == null || pessoa.Idade == 0)
            {
                return false;            
            }
            else
            {
                bool condition = ;
                return condition;                        
            }
        }
        public bool Get(Guid id){
            if(id == null)
            {
                return false;                
            }
            else
            {
                bool condition = ;
                return condition;
            } 
        }
        public Task Remove(Guid id){
            if(id == null)
            {
                return false;                
            }
            else
            {
                bool condition = ;
                return condition;
            } 
        }
        public Task Details(Guid id){
            if(id == null)
            {
                return false;                
            }
            else
            {
                bool condition = ;
                return condition;
            } 
        }
    }
}