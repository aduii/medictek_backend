using System.Collections.Generic;
using MyE.Entity;
using MyE.Repository;
namespace MyE.Service.Implementation
{
    public class MedicalEquipmentService : IMedicalEquipmentService
    {
        private IMedicalEquipmentRepository medicalEquipmentRepository;
        public MedicalEquipmentService(IMedicalEquipmentRepository medicalEquipmentRepository)
        {
           this.medicalEquipmentRepository = medicalEquipmentRepository;
        }
         public bool Delete(int id)
        {
          return this.medicalEquipmentRepository.Delete(id);
        }

        public MedicalEquipment Get(int id)
        {
           return this.medicalEquipmentRepository.Get(id);
        }

        public IEnumerable<MedicalEquipment> GetAll()
        {
            return this.medicalEquipmentRepository.GetAll();
        }

        public bool Save(MedicalEquipment entity)
        {
            return this.medicalEquipmentRepository.Save(entity);
        }

        public bool Update(MedicalEquipment entity)
        {
            return this.medicalEquipmentRepository.Update(entity);
        }
    }
}