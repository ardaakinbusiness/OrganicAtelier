﻿using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.DAL.Abstract;
using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void Create(Slider entity)
        {
            _sliderDal.Create(entity);
        }

        public Slider GetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public void Delete(Slider entity)
        {
            _sliderDal.Delete(entity);
        }

        public Slider GetOne(Expression<Func<Slider, bool>> filter = null)
        {
            return _sliderDal.GetOne(filter);
        }

        public void Update(Slider entity)
        {
            _sliderDal.Update(entity);
        }

        List<Slider> ISliderService.GetAll(Expression<Func<Slider, bool>> filter = null)
        {
            return _sliderDal.GetAll(filter);
        }
    }
}
