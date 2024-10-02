﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.ContactDTO;

namespace OrganicAtelier.WEBUI.ViewComponents.Layout
{
    public class _LayoutFooterViewComponentPartial : ViewComponent
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public _LayoutFooterViewComponentPartial(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<ResultContactDTO>(_contactService.GetOne()));
        }
    }
}

    

