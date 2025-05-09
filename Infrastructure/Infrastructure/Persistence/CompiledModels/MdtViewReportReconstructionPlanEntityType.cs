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
    public partial class MdtViewReportReconstructionPlanEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.MdtViewReportReconstructionPlan",
                typeof(MdtViewReportReconstructionPlan),
                baseEntityType,
                propertyCount: 27);

            var currentId = runtimeEntityType.AddProperty(
                "CurrentId",
                typeof(Guid?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("CurrentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<CurrentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            currentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var currentLocationValue = runtimeEntityType.AddProperty(
                "CurrentLocationValue",
                typeof(string),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("CurrentLocationValue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<CurrentLocationValue>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 300);
            currentLocationValue.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var height = runtimeEntityType.AddProperty(
                "Height",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("Height", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<Height>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            height.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var imageName = runtimeEntityType.AddProperty(
                "ImageName",
                typeof(string),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("ImageName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<ImageName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            imageName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var imagePath = runtimeEntityType.AddProperty(
                "ImagePath",
                typeof(string),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("ImagePath", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<ImagePath>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 300);
            imagePath.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isTouchedDown = runtimeEntityType.AddProperty(
                "IsTouchedDown",
                typeof(bool?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("IsTouchedDown", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<IsTouchedDown>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isTouchedDown.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var latitudeValue = runtimeEntityType.AddProperty(
                "LatitudeValue",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("LatitudeValue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<LatitudeValue>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            latitudeValue.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var longitudeValue = runtimeEntityType.AddProperty(
                "LongitudeValue",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("LongitudeValue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<LongitudeValue>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            longitudeValue.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var m11 = runtimeEntityType.AddProperty(
                "M11",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("M11", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<M11>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            m11.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var m12 = runtimeEntityType.AddProperty(
                "M12",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("M12", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<M12>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            m12.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var m21 = runtimeEntityType.AddProperty(
                "M21",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("M21", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<M21>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            m21.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var m22 = runtimeEntityType.AddProperty(
                "M22",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("M22", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<M22>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            m22.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var mapMode = runtimeEntityType.AddProperty(
                "MapMode",
                typeof(string),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("MapMode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<MapMode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            mapMode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var offsetX = runtimeEntityType.AddProperty(
                "OffsetX",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("OffsetX", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<OffsetX>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            offsetX.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var offsetY = runtimeEntityType.AddProperty(
                "OffsetY",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("OffsetY", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<OffsetY>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            offsetY.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reconstructionGraphId = runtimeEntityType.AddProperty(
                "ReconstructionGraphId",
                typeof(int),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("ReconstructionGraphId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<ReconstructionGraphId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            reconstructionGraphId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reconstructionMapId = runtimeEntityType.AddProperty(
                "ReconstructionMapId",
                typeof(int),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("ReconstructionMapId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<ReconstructionMapId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            reconstructionMapId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportId = runtimeEntityType.AddProperty(
                "ReportId",
                typeof(int),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("ReportId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<ReportId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            reportId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rotateValue = runtimeEntityType.AddProperty(
                "RotateValue",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("RotateValue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<RotateValue>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rotateValue.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var searchAddress = runtimeEntityType.AddProperty(
                "SearchAddress",
                typeof(string),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("SearchAddress", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<SearchAddress>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 300);
            searchAddress.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var selectedMap = runtimeEntityType.AddProperty(
                "SelectedMap",
                typeof(string),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("SelectedMap", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<SelectedMap>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            selectedMap.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var selectedMapTypeId = runtimeEntityType.AddProperty(
                "SelectedMapTypeId",
                typeof(long?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("SelectedMapTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<SelectedMapTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            selectedMapTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var width = runtimeEntityType.AddProperty(
                "Width",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("Width", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<Width>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            width.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var xaxis = runtimeEntityType.AddProperty(
                "Xaxis",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("Xaxis", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<Xaxis>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            xaxis.AddAnnotation("Relational:ColumnName", "XAxis");
            xaxis.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var yaxis = runtimeEntityType.AddProperty(
                "Yaxis",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("Yaxis", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<Yaxis>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            yaxis.AddAnnotation("Relational:ColumnName", "YAxis");
            yaxis.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var zoomLevel = runtimeEntityType.AddProperty(
                "ZoomLevel",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("ZoomLevel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<ZoomLevel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            zoomLevel.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var zoomTickFrequency = runtimeEntityType.AddProperty(
                "ZoomTickFrequency",
                typeof(double?),
                propertyInfo: typeof(MdtViewReportReconstructionPlan).GetProperty("ZoomTickFrequency", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MdtViewReportReconstructionPlan).GetField("<ZoomTickFrequency>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            zoomTickFrequency.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "MdtViewReportReconstructionPlan");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
