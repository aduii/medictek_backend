using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository.Context;
using System.Linq;

namespace MyE.Repository.Implementation
{
    public class MedicalEquipmentRepository : IMedicalEquipmentRepository
    {
        private ApplicationDbContext context;
        public MedicalEquipmentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new MedicalEquipment();
                result = context.MedicalEquipments.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public MedicalEquipment Get(int id)
        {
             var result = new MedicalEquipment();
            try {
                result = context.MedicalEquipments.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<MedicalEquipment> GetAll()
        {
            var result = new List<MedicalEquipment>();
            try{
                result = context.MedicalEquipments.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(MedicalEquipment entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(MedicalEquipment entity)
        {
            try{
                var newMedicalEquipment = context.MedicalEquipments.Single(x => x.Id == entity.Id);
                newMedicalEquipment.Id = entity.Id;
                newMedicalEquipment.StateDescription = entity.StateDescription;
                newMedicalEquipment.Brand = entity.Brand;
                newMedicalEquipment.Name = entity.Name;
                context.Update(newMedicalEquipment);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return true;
            }
            return false;
        }
    }
}