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
    public partial class ErrEnvolvedLogEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ErrEnvolvedLog",
                typeof(ErrEnvolvedLog),
                baseEntityType,
                propertyCount: 7);

            var accId = runtimeEntityType.AddProperty(
                "AccId",
                typeof(string),
                propertyInfo: typeof(ErrEnvolvedLog).GetProperty("AccId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ErrEnvolvedLog).GetField("<AccId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 14);
            accId.AddAnnotation("Relational:ColumnName", "ACC_ID");
            accId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var crDate = runtimeEntityType.AddProperty(
                "CrDate",
                typeof(DateTime?),
                propertyInfo: typeof(ErrEnvolvedLog).GetProperty("CrDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ErrEnvolvedLog).GetField("<CrDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            crDate.AddAnnotation("Relational:ColumnName", "CR_DATE");
            crDate.AddAnnotation("Relational:ColumnType", "datetime");
            crDate.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            crDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var errCode = runtimeEntityType.AddProperty(
                "ErrCode",
                typeof(int?),
                propertyInfo: typeof(ErrEnvolvedLog).GetProperty("ErrCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ErrEnvolvedLog).GetField("<ErrCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            errCode.AddAnnotation("Relational:ColumnName", "ERR_CODE");
            errCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var errDesc = runtimeEntityType.AddProperty(
                "ErrDesc",
                typeof(string),
                propertyInfo: typeof(ErrEnvolvedLog).GetProperty("ErrDesc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ErrEnvolvedLog).GetField("<ErrDesc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            errDesc.AddAnnotation("Relational:ColumnName", "ERR_DESC");
            errDesc.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var errDescEn = runtimeEntityType.AddProperty(
                "ErrDescEn",
                typeof(string),
                propertyInfo: typeof(ErrEnvolvedLog).GetProperty("ErrDescEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ErrEnvolvedLog).GetField("<ErrDescEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            errDescEn.AddAnnotation("Relational:ColumnName", "ERR_DESC_EN");
            errDescEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var tId = runtimeEntityType.AddProperty(
                "TId",
                typeof(int),
                propertyInfo: typeof(ErrEnvolvedLog).GetProperty("TId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ErrEnvolvedLog).GetField("<TId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: 0);
            tId.AddAnnotation("Relational:ColumnName", "T_ID");
            tId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var vecId = runtimeEntityType.AddProperty(
                "VecId",
                typeof(string),
                propertyInfo: typeof(ErrEnvolvedLog).GetProperty("VecId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ErrEnvolvedLog).GetField("<VecId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 12);
            vecId.AddAnnotation("Relational:ColumnName", "VEC_ID");
            vecId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ERR_ENVOLVED_LOG");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
