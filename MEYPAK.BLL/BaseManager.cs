using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL
{
    public class BaseManager<Poco, T> : IGenericServis<Poco> where Poco : class, new() where T : class, new()
    {
        IGeneric<T> _repo;
        private readonly IMapper _mapper;
        private readonly string _includeEntities;

        public BaseManager(IMapper mapper, IGeneric<T> repo,string includeEntities = null)
        {
            _mapper = mapper;
            _repo = repo;
            _includeEntities = includeEntities;
        }

        //Asagidaki yorum satilari da is goruyor fatak denemek istedim. boyle calisirsa daha verimli olur.
        public Poco Ekle(Poco pModel)
        {
            T Model = _mapper.Map<Poco, T>(pModel);
            //T RepoResult = _repo.Ekle(Model);
            Poco pRModel = _mapper.Map<T, Poco>(_repo.Ekle(Model));
            //Poco Result = _mapper.Map<T, Poco>(RepoResult);
            return pRModel;
        }

        public List<Poco> Getir(Expression<Func<Poco, bool>> filter)
        {
            var fltr = _mapper.Map<Expression<Func<Poco, bool>>,
                    Expression<Func<T, bool>>>(filter);
            

            List<Poco> dataList =
                    _mapper.Map<List<T>, List<Poco>>(_repo.Getir(fltr));
            return dataList;
        }

        public Durum Guncelle(Poco pModel, Expression<Func<Poco, bool>> filter)
        {
            var fltr = _mapper.Map<Expression<Func<Poco, bool>>,
                   Expression<Func<T, bool>>>(filter);

            T model = _mapper.Map<Poco,T>(pModel);

            return _repo.Guncelle(model, fltr);
        }

        public Durum Guncelle(Poco pModel)
        {
            T model = _mapper.Map<Poco,T>(pModel);
            
            Poco pRModel = _mapper.Map<T, Poco>(_repo.Guncelle(model));
            return Durum.güncellemebaşarılı;

        }

        public List<Poco> Listele()
        {
            return _mapper.Map<List<T>, List<Poco>>(_repo.Listele());
        }

      

        public bool Sil(List<Poco> pModels)
        {

            return _repo.Sil(_mapper.Map<List<Poco>, List<T>>(pModels));
        }

        public bool DeleteById(int id)
        {
            return _repo.DeleteById(id);
        }

        public Poco EkleyadaGuncelle(Poco entity)
        {
            T Model = _mapper.Map<Poco, T>(entity); 
            Poco pRModel = _mapper.Map<T, Poco>(_repo.Ekle(Model)); 
            return pRModel;
        }
    }
}
