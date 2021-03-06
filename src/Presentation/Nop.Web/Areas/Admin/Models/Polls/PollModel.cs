﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Areas.Admin.Validators.Polls;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Web.Areas.Admin.Models.Polls
{
    /// <summary>
    /// Represents a poll model
    /// </summary>
    [Validator(typeof(PollValidator))]
    public partial class PollModel : BaseNopEntityModel, IStoreMappingSupportedModel
    {
        #region Ctor

        public PollModel()
        {
            AvailableLanguages = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            SelectedStoreIds = new List<int>();
            PollAnswerSearchModel = new PollAnswerSearchModel();
        }

        #endregion

        #region Properties

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.Language")]
        public int LanguageId { get; set; }

        public IList<SelectListItem> AvailableLanguages { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.Language")]
        public string LanguageName { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.Name")]
        public string Name { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.Published")]
        public bool Published { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.ShowOnHomepage")]
        public bool ShowOnHomepage { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.AllowGuestsToVote")]
        public bool AllowGuestsToVote { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.StartDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDateUtc { get; set; }

        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.EndDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDateUtc { get; set; }
        
        [NopResourceDisplayName("Admin.ContentManagement.Polls.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public PollAnswerSearchModel PollAnswerSearchModel { get; set; }

        //TODO find more elegant way
        //workaround to add locales copied from \Models\Polls\PollAnswerModel.cs)
        //we cannot use "LocaleResourceModel" property because it's automatically validated when editing a language
        [NopResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.Name")]
        public string AddName { get; set; }
        [NopResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.DisplayOrder")]
        public int AddDisplayOrder { get; set; }


        #endregion
    }
}