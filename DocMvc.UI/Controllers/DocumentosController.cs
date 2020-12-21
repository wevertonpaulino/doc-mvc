﻿using AutoMapper;
using DocMvc.Application.Abstractions;
using DocMvc.Domain.Entities;
using DocMvc.UI.Mapping;
using DocMvc.UI.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DocMvc.UI.Controllers
{
    public class DocumentosController : Controller
    {
        private readonly IDocumentoAppService _documentoAppService;
        private readonly IMapper _mapper = AutoMapperConfig.Mapper;

        public DocumentosController(IDocumentoAppService documentoAppService)
        {
            _documentoAppService = documentoAppService;
        }

        // GET: Documentos
        public ActionResult Index()
        {
            var documentos = _documentoAppService.GetAll();
            var documentoViewModel = _mapper.Map<IEnumerable<Documento>, IEnumerable<DocumentoViewModel>>(documentos);

            return View(documentoViewModel);
        }

        // GET: Documentos/Details/5
        public ActionResult Details(int id)
        {
            var documento = _documentoAppService.GetByCodigo(id);
            var documentoViewModel = _mapper.Map<Documento, DocumentoViewModel>(documento);

            return View(documentoViewModel);
        }

        // GET: Documentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Documentos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DocumentoViewModel documentoViewModel)
        {
            if (ModelState.IsValid)
            {
                var documento = _mapper.Map<DocumentoViewModel, Documento>(documentoViewModel);
                _documentoAppService.Add(documento);

                return RedirectToAction("Index");
            }

            return View(documentoViewModel);
        }

        // GET: Documentos/Edit/5
        public ActionResult Edit(int id)
        {
            var documento = _documentoAppService.GetByCodigo(id);
            var documentoViewModel = _mapper.Map<Documento, DocumentoViewModel>(documento);

            return View(documentoViewModel);
        }

        // POST: Documentos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DocumentoViewModel documentoViewModel)
        {
            if (ModelState.IsValid)
            {
                var documento = _mapper.Map<DocumentoViewModel, Documento>(documentoViewModel);
                _documentoAppService.Update(documento);

                return RedirectToAction("Index");
            }

            return View(documentoViewModel);
        }

        // GET: Documentos/Delete/5
        public ActionResult Delete(int id)
        {
            var documento = _documentoAppService.GetByCodigo(id);
            var documentoViewModel = _mapper.Map<Documento, DocumentoViewModel>(documento);

            return View(documentoViewModel);
        }

        // POST: Documentos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(DocumentoViewModel documentoViewModel)
        {
            var documento = _mapper.Map<DocumentoViewModel, Documento>(documentoViewModel);
            _documentoAppService.Remove(documento);

            return RedirectToAction("Index");
        }
    }
}
