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
    public partial class VGetReportCustomerChanelDetailEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.VGetReportCustomerChanelDetail",
                typeof(VGetReportCustomerChanelDetail),
                baseEntityType,
                propertyCount: 10);

            var customerName = runtimeEntityType.AddProperty(
                "CustomerName",
                typeof(string),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("CustomerName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<CustomerName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 3000);
            customerName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var email = runtimeEntityType.AddProperty(
                "Email",
                typeof(string),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("Email", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<Email>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 2,
                unicode: false);
            email.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var mobileNumber = runtimeEntityType.AddProperty(
                "MobileNumber",
                typeof(string),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("MobileNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<MobileNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            mobileNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nationality = runtimeEntityType.AddProperty(
                "Nationality",
                typeof(string),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("Nationality", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<Nationality>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            nationality.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportDateTime = runtimeEntityType.AddProperty(
                "ReportDateTime",
                typeof(DateTime),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("ReportDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<ReportDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            reportDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            reportDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportSource = runtimeEntityType.AddProperty(
                "ReportSource",
                typeof(string),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("ReportSource", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<ReportSource>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 21);
            reportSource.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serviceName = runtimeEntityType.AddProperty(
                "ServiceName",
                typeof(string),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("ServiceName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<ServiceName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            serviceName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serviceTypeId = runtimeEntityType.AddProperty(
                "ServiceTypeId",
                typeof(int),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("ServiceTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<ServiceTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            serviceTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var tcn = runtimeEntityType.AddProperty(
                "Tcn",
                typeof(string),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("Tcn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<Tcn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 3000);
            tcn.AddAnnotation("Relational:ColumnName", "TCN");
            tcn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vehicleDataId = runtimeEntityType.AddProperty(
                "VehicleDataId",
                typeof(int),
                propertyInfo: typeof(VGetReportCustomerChanelDetail).GetProperty("VehicleDataId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VGetReportCustomerChanelDetail).GetField("<VehicleDataId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            vehicleDataId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "V_GetReportCustomerChanelDetails");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
