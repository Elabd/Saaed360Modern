﻿// <auto-generated />
using System;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class MobileRequestSurveyQuestionEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.MobileRequestSurveyQuestion",
                typeof(MobileRequestSurveyQuestion),
                baseEntityType,
                propertyCount: 3,
                navigationCount: 1,
                keyCount: 1);

            var mobileRequestSurveyQuestionId = runtimeEntityType.AddProperty(
                "MobileRequestSurveyQuestionId",
                typeof(int),
                propertyInfo: typeof(MobileRequestSurveyQuestion).GetProperty("MobileRequestSurveyQuestionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileRequestSurveyQuestion).GetField("<MobileRequestSurveyQuestionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            mobileRequestSurveyQuestionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var questionDescAr = runtimeEntityType.AddProperty(
                "QuestionDescAr",
                typeof(string),
                propertyInfo: typeof(MobileRequestSurveyQuestion).GetProperty("QuestionDescAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileRequestSurveyQuestion).GetField("<QuestionDescAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 500);
            questionDescAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var questionDescEn = runtimeEntityType.AddProperty(
                "QuestionDescEn",
                typeof(string),
                propertyInfo: typeof(MobileRequestSurveyQuestion).GetProperty("QuestionDescEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileRequestSurveyQuestion).GetField("<QuestionDescEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 500);
            questionDescEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { mobileRequestSurveyQuestionId });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "MobileRequestSurveyQuestions");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
