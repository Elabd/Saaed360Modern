﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class EsStepEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.EsStep",
                typeof(EsStep),
                baseEntityType,
                propertyCount: 10,
                navigationCount: 2,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                namedIndexCount: 4,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(EsStep).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var createdAt = runtimeEntityType.AddProperty(
                "CreatedAt",
                typeof(DateTime),
                propertyInfo: typeof(EsStep).GetProperty("CreatedAt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<CreatedAt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createdAt.AddAnnotation("Relational:ColumnType", "datetime");
            createdAt.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            createdAt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var index = runtimeEntityType.AddProperty(
                "Index",
                typeof(int),
                propertyInfo: typeof(EsStep).GetProperty("Index", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<Index>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            index.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(EsStep).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedAt = runtimeEntityType.AddProperty(
                "ModifiedAt",
                typeof(DateTime?),
                propertyInfo: typeof(EsStep).GetProperty("ModifiedAt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<ModifiedAt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifiedAt.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedAt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nameArabic = runtimeEntityType.AddProperty(
                "NameArabic",
                typeof(string),
                propertyInfo: typeof(EsStep).GetProperty("NameArabic", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<NameArabic>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 255);
            nameArabic.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nameEnglish = runtimeEntityType.AddProperty(
                "NameEnglish",
                typeof(string),
                propertyInfo: typeof(EsStep).GetProperty("NameEnglish", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<NameEnglish>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 255);
            nameEnglish.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nameUrdu = runtimeEntityType.AddProperty(
                "NameUrdu",
                typeof(string),
                propertyInfo: typeof(EsStep).GetProperty("NameUrdu", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<NameUrdu>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 255);
            nameUrdu.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serviceId = runtimeEntityType.AddProperty(
                "ServiceId",
                typeof(int),
                propertyInfo: typeof(EsStep).GetProperty("ServiceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<ServiceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            serviceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userControlId = runtimeEntityType.AddProperty(
                "UserControlId",
                typeof(int),
                propertyInfo: typeof(EsStep).GetProperty("UserControlId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<UserControlId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            userControlId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__ES_Step__3214EC0740308F38");

            var index0 = runtimeEntityType.AddIndex(
                new[] { userControlId });

            var uK_Step_ServiceId_StepIndex = runtimeEntityType.AddIndex(
                new[] { serviceId, index },
                name: "UK_Step_ServiceId_StepIndex",
                unique: true);

            var uK_Step_ServiceId_Step_NameArabic = runtimeEntityType.AddIndex(
                new[] { serviceId, nameArabic },
                name: "UK_Step_ServiceId_Step_NameArabic",
                unique: true);

            var uK_Step_ServiceId_Step_NameEnglish = runtimeEntityType.AddIndex(
                new[] { serviceId, nameEnglish },
                name: "UK_Step_ServiceId_Step_NameEnglish",
                unique: true);

            var uK_Step_ServiceId_Step_NameUrdu = runtimeEntityType.AddIndex(
                new[] { serviceId, nameUrdu },
                name: "UK_Step_ServiceId_Step_NameUrdu",
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ServiceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var service = declaringEntityType.AddNavigation("Service",
                runtimeForeignKey,
                onDependent: true,
                typeof(EsService),
                propertyInfo: typeof(EsStep).GetProperty("Service", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<Service>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var esSteps = principalEntityType.AddNavigation("EsSteps",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EsStep>),
                propertyInfo: typeof(EsService).GetProperty("EsSteps", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsService).GetField("<EsSteps>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Step_Service");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("UserControlId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var userControl = declaringEntityType.AddNavigation("UserControl",
                runtimeForeignKey,
                onDependent: true,
                typeof(EsUserControlDim),
                propertyInfo: typeof(EsStep).GetProperty("UserControl", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsStep).GetField("<UserControl>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var esSteps = principalEntityType.AddNavigation("EsSteps",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EsStep>),
                propertyInfo: typeof(EsUserControlDim).GetProperty("EsSteps", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EsUserControlDim).GetField("<EsSteps>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Step_UserControl");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ES_Step");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
