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
    public partial class RepairInvoiceEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.RepairInvoice",
                typeof(RepairInvoice),
                baseEntityType,
                propertyCount: 8,
                navigationCount: 2,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                namedIndexCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long),
                propertyInfo: typeof(RepairInvoice).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var filePath = runtimeEntityType.AddProperty(
                "FilePath",
                typeof(string),
                propertyInfo: typeof(RepairInvoice).GetProperty("FilePath", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<FilePath>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 265);
            filePath.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(RepairInvoice).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModificationDate = runtimeEntityType.AddProperty(
                "LastModificationDate",
                typeof(DateTime?),
                propertyInfo: typeof(RepairInvoice).GetProperty("LastModificationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<LastModificationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModificationDate.AddAnnotation("Relational:ColumnType", "datetime");
            lastModificationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModifiedBy = runtimeEntityType.AddProperty(
                "LastModifiedBy",
                typeof(long),
                propertyInfo: typeof(RepairInvoice).GetProperty("LastModifiedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<LastModifiedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            lastModifiedBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var repairQuoteId = runtimeEntityType.AddProperty(
                "RepairQuoteId",
                typeof(long),
                propertyInfo: typeof(RepairInvoice).GetProperty("RepairQuoteId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<RepairQuoteId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            repairQuoteId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var uploadByPersonId = runtimeEntityType.AddProperty(
                "UploadByPersonId",
                typeof(long),
                propertyInfo: typeof(RepairInvoice).GetProperty("UploadByPersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<UploadByPersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            uploadByPersonId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var uploadDate = runtimeEntityType.AddProperty(
                "UploadDate",
                typeof(DateTime),
                propertyInfo: typeof(RepairInvoice).GetProperty("UploadDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<UploadDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            uploadDate.AddAnnotation("Relational:ColumnType", "datetime");
            uploadDate.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            uploadDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__RepairIn__3214EC0751A1AC15");

            var index = runtimeEntityType.AddIndex(
                new[] { uploadByPersonId });

            var uK_RepairQuote = runtimeEntityType.AddIndex(
                new[] { repairQuoteId },
                name: "UK_RepairQuote",
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RepairQuoteId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                unique: true,
                required: true);

            var repairQuote = declaringEntityType.AddNavigation("RepairQuote",
                runtimeForeignKey,
                onDependent: true,
                typeof(RepairQuote),
                propertyInfo: typeof(RepairInvoice).GetProperty("RepairQuote", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<RepairQuote>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var repairInvoice = principalEntityType.AddNavigation("RepairInvoice",
                runtimeForeignKey,
                onDependent: false,
                typeof(RepairInvoice),
                propertyInfo: typeof(RepairQuote).GetProperty("RepairInvoice", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairQuote).GetField("<RepairInvoice>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_RepairInvoice_RepairQuote");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("UploadByPersonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType,
                required: true);

            var uploadByPerson = declaringEntityType.AddNavigation("UploadByPerson",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(RepairInvoice).GetProperty("UploadByPerson", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RepairInvoice).GetField("<UploadByPerson>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var repairInvoices = principalEntityType.AddNavigation("RepairInvoices",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RepairInvoice>),
                propertyInfo: typeof(Person).GetProperty("RepairInvoices", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<RepairInvoices>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_RepairInvoice_Person");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "RepairInvoice");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
