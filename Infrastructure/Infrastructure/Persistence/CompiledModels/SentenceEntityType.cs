﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class SentenceEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.Sentence",
                typeof(Sentence),
                baseEntityType,
                propertyCount: 14,
                navigationCount: 2,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                keyCount: 1);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(Sentence).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceAggravatedIndicator = runtimeEntityType.AddProperty(
                "SentenceAggravatedIndicator",
                typeof(bool),
                propertyInfo: typeof(Sentence).GetProperty("SentenceAggravatedIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceAggravatedIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            sentenceAggravatedIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceConfinementCreditDayQuantity = runtimeEntityType.AddProperty(
                "SentenceConfinementCreditDayQuantity",
                typeof(int),
                propertyInfo: typeof(Sentence).GetProperty("SentenceConfinementCreditDayQuantity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceConfinementCreditDayQuantity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            sentenceConfinementCreditDayQuantity.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceConfinementCreditIndicator = runtimeEntityType.AddProperty(
                "SentenceConfinementCreditIndicator",
                typeof(bool),
                propertyInfo: typeof(Sentence).GetProperty("SentenceConfinementCreditIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceConfinementCreditIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            sentenceConfinementCreditIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceDeferredIndicator = runtimeEntityType.AddProperty(
                "SentenceDeferredIndicator",
                typeof(bool),
                propertyInfo: typeof(Sentence).GetProperty("SentenceDeferredIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceDeferredIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            sentenceDeferredIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceDeferredTermMaxDuration = runtimeEntityType.AddProperty(
                "SentenceDeferredTermMaxDuration",
                typeof(DateOnly?),
                propertyInfo: typeof(Sentence).GetProperty("SentenceDeferredTermMaxDuration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceDeferredTermMaxDuration>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sentenceDeferredTermMaxDuration.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceDeferredTermMinDuration = runtimeEntityType.AddProperty(
                "SentenceDeferredTermMinDuration",
                typeof(DateOnly?),
                propertyInfo: typeof(Sentence).GetProperty("SentenceDeferredTermMinDuration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceDeferredTermMinDuration>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sentenceDeferredTermMinDuration.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceGroupingId = runtimeEntityType.AddProperty(
                "SentenceGroupingId",
                typeof(int),
                propertyInfo: typeof(Sentence).GetProperty("SentenceGroupingId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceGroupingId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: 0);
            sentenceGroupingId.AddAnnotation("Relational:DefaultValue", 1);
            sentenceGroupingId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceRegisterSexOffenderIndicator = runtimeEntityType.AddProperty(
                "SentenceRegisterSexOffenderIndicator",
                typeof(bool),
                propertyInfo: typeof(Sentence).GetProperty("SentenceRegisterSexOffenderIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceRegisterSexOffenderIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            sentenceRegisterSexOffenderIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceSuspendedIndicator = runtimeEntityType.AddProperty(
                "SentenceSuspendedIndicator",
                typeof(bool),
                propertyInfo: typeof(Sentence).GetProperty("SentenceSuspendedIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceSuspendedIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            sentenceSuspendedIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceSuspendedTermMaxDuration = runtimeEntityType.AddProperty(
                "SentenceSuspendedTermMaxDuration",
                typeof(DateOnly?),
                propertyInfo: typeof(Sentence).GetProperty("SentenceSuspendedTermMaxDuration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceSuspendedTermMaxDuration>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sentenceSuspendedTermMaxDuration.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceSuspendedTermMinDuration = runtimeEntityType.AddProperty(
                "SentenceSuspendedTermMinDuration",
                typeof(DateOnly?),
                propertyInfo: typeof(Sentence).GetProperty("SentenceSuspendedTermMinDuration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceSuspendedTermMinDuration>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sentenceSuspendedTermMinDuration.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceTermMaxDuration = runtimeEntityType.AddProperty(
                "SentenceTermMaxDuration",
                typeof(DateOnly?),
                propertyInfo: typeof(Sentence).GetProperty("SentenceTermMaxDuration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceTermMaxDuration>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sentenceTermMaxDuration.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sentenceTermMinDuration = runtimeEntityType.AddProperty(
                "SentenceTermMinDuration",
                typeof(DateOnly?),
                propertyInfo: typeof(Sentence).GetProperty("SentenceTermMinDuration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceTermMinDuration>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sentenceTermMinDuration.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { activityId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { sentenceGroupingId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ActivityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ActivityId") }),
                principalEntityType,
                unique: true,
                required: true);

            var activity = declaringEntityType.AddNavigation("Activity",
                runtimeForeignKey,
                onDependent: true,
                typeof(Activity),
                propertyInfo: typeof(Sentence).GetProperty("Activity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<Activity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var sentence = principalEntityType.AddNavigation("Sentence",
                runtimeForeignKey,
                onDependent: false,
                typeof(Sentence),
                propertyInfo: typeof(Activity).GetProperty("Sentence", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Activity).GetField("<Sentence>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Sentence_Activity");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SentenceGroupingId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("SentenceGroupingId") }),
                principalEntityType,
                required: true);

            var sentenceGrouping = declaringEntityType.AddNavigation("SentenceGrouping",
                runtimeForeignKey,
                onDependent: true,
                typeof(SentenceGroupingDim),
                propertyInfo: typeof(Sentence).GetProperty("SentenceGrouping", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Sentence).GetField("<SentenceGrouping>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var sentences = principalEntityType.AddNavigation("Sentences",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Sentence>),
                propertyInfo: typeof(SentenceGroupingDim).GetProperty("Sentences", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SentenceGroupingDim).GetField("<Sentences>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Sentence_SentenceGroupingDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Sentence");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
