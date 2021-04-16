using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiGresol.DTO;
using WebApiGresol.Repositories;
using WebApiGresol.Model;
using AutoMapper;

namespace WebApiGresol.Service
{
    public class ThirdPartyService : IThirdPartyService
    {
        private readonly IUnitOfWork unitOfWork;
        private ThirdParty thirdParty;
        public ThirdPartyService(IUnitOfWork uoW)
        {

            this.unitOfWork = uoW;
            thirdParty = new ThirdParty();
        }

        public async Task<DtoThirdParty> GetThirdPartyById(int Id)
        {
            DtoThirdParty dtoThirdParty = new DtoThirdParty();
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<ThirdParty, DtoThirdParty>());
            IMapper iMapper = configuration.CreateMapper();

            thirdParty =  await unitOfWork.ThirdPartyRepository.GetEntityById(Id);
            iMapper.Map(thirdParty, dtoThirdParty);

            return  dtoThirdParty;
        }
        public IQueryable<DtoThirdParty> GetDtoThirdParties()
        {

            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<ThirdParty,DtoThirdParty>());
            IMapper iMapper = configuration.CreateMapper();

            // List<ThirdParty> source = unitOfWork.ThirdPartyRepository.GetEntities().ToList();
            List<ThirdParty> source = unitOfWork.ThirdPartyRepository.GetEntities().OrderBy(t => t.Name).ToList();

            //IQueryable<DtoThirdParty> listDest = iMapper.Map<IQueryable<ThirdParty>, IQueryable<DtoThirdParty>> (source);
            IQueryable<DtoThirdParty> listDest = (iMapper.Map<List<ThirdParty>, List<DtoThirdParty>>(source)).AsQueryable();

            return listDest;

        
        }
        public async Task DeleteThirdParty(int Id)
        {
            thirdParty = await unitOfWork.ThirdPartyRepository.GetEntityById(Id);
            unitOfWork.ThirdPartyRepository.Delete(thirdParty);
        }

        public async Task<int> SaveThirdParty(DtoThirdParty dtoThirdParty)
        {
            int isSave = 0;


            if (dtoThirdParty == null)
                return 0;


            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DtoThirdParty, ThirdParty>();
            });
            IMapper iMapper = config.CreateMapper();
            iMapper.Map(dtoThirdParty, thirdParty);

            var insertOperation =  unitOfWork.ThirdPartyRepository.Insert(thirdParty);
            var saveOperation =  unitOfWork.Commit();
            await Task.WhenAll(insertOperation, saveOperation);
            isSave = saveOperation.Result;
            return isSave; 


        }

        public bool UpdateThirdParty(int Id, DtoThirdParty dtoThirdParty)
        {
            bool isUpdate = false;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DtoThirdParty, ThirdParty>();
            });
            IMapper iMapper = config.CreateMapper();
            iMapper.Map(dtoThirdParty, thirdParty);

            thirdParty.ThirdPartyID = Id;
            unitOfWork.ThirdPartyRepository.Update(thirdParty);


            return isUpdate;
        }
    }
}
