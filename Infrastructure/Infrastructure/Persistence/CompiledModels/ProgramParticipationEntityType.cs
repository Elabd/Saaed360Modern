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
    public partial class ProgramParticipationEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ProgramParticipation",
                typeof(ProgramParticipation),
                baseEntityType,
                propertyCount: 7,
                navigationCount: 4,
                foreignKeyCount: 4,
                unnamedIndexCount: 3,
                keyCount: 1);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var programId = runtimeEntityType.AddProperty(
                "ProgramId",
                typeof(int),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ProgramId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ProgramId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            programId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var programPubliclyRunIndicator = runtimeEntityType.AddProperty(
                "ProgramPubliclyRunIndicator",
                typeof(bool),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ProgramPubliclyRunIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ProgramPubliclyRunIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: true);
            programPubliclyRunIndicator.AddAnnotation("Relational:DefaultValue", true);
            programPubliclyRunIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var programReferralStatusId = runtimeEntityType.AddProperty(
                "ProgramReferralStatusId",
                typeof(int),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ProgramReferralStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ProgramReferralStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            programReferralStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var programRepatedIndicator = runtimeEntityType.AddProperty(
                "ProgramRepatedIndicator",
                typeof(bool),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ProgramRepatedIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ProgramRepatedIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            programRepatedIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var programStatusId = runtimeEntityType.AddProperty(
                "ProgramStatusId",
                typeof(int),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ProgramStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ProgramStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            programStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var referredDateTime = runtimeEntityType.AddProperty(
                "ReferredDateTime",
                typeof(DateTime),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ReferredDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ReferredDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            referredDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            referredDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { activityId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { programId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { programReferralStatusId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { programStatusId });

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
                propertyInfo: typeof(ProgramParticipation).GetProperty("Activity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<Activity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var programParticipation = principalEntityType.AddNavigation("ProgramParticipation",
                runtimeForeignKey,
                onDependent: false,
                typeof(ProgramParticipation),
                propertyInfo: typeof(Activity).GetProperty("ProgramParticipation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Activity).GetField("<ProgramParticipation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_ProgramParticipation_Activity");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ProgramId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ProgramId") }),
                principalEntityType,
                required: true);

            var program = declaringEntityType.AddNavigation("Program",
                runtimeForeignKey,
                onDependent: true,
                typeof(ProgramDim),
                propertyInfo: typeof(ProgramParticipation).GetProperty("Program", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<Program>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var programParticipations = principalEntityType.AddNavigation("ProgramParticipations",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<ProgramParticipation>),
                propertyInfo: typeof(ProgramDim).GetProperty("ProgramParticipations", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramDim).GetField("<ProgramParticipations>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_ProgramParticipation_ProgramDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ProgramReferralStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ProgramReferralStatusId") }),
                principalEntityType,
                required: true);

            var programReferralStatus = declaringEntityType.AddNavigation("ProgramReferralStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(ProgramReferralStatusDim),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ProgramReferralStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ProgramReferralStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var programParticipations = principalEntityType.AddNavigation("ProgramParticipations",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<ProgramParticipation>),
                propertyInfo: typeof(ProgramReferralStatusDim).GetProperty("ProgramParticipations", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramReferralStatusDim).GetField("<ProgramParticipations>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_ProgramParticipation_ProgramReferralStatusDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ProgramStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ProgramStatusId") }),
                principalEntityType,
                required: true);

            var programStatus = declaringEntityType.AddNavigation("ProgramStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(ProgramStatusDim),
                propertyInfo: typeof(ProgramParticipation).GetProperty("ProgramStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramParticipation).GetField("<ProgramStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var programParticipations = principalEntityType.AddNavigation("ProgramParticipations",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<ProgramParticipation>),
                propertyInfo: typeof(ProgramStatusDim).GetProperty("ProgramParticipations", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ProgramStatusDim).GetField("<ProgramParticipations>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_ProgramParticipation_ProgramStatusDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ProgramParticipation");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
