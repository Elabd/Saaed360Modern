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
    public partial class WebApiRequestsLogEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.WebApiRequestsLog",
                typeof(WebApiRequestsLog),
                baseEntityType,
                propertyCount: 17,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var actionName = runtimeEntityType.AddProperty(
                "ActionName",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("ActionName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<ActionName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            actionName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var applicationName = runtimeEntityType.AddProperty(
                "ApplicationName",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("ApplicationName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<ApplicationName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            applicationName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var detailedMessage = runtimeEntityType.AddProperty(
                "DetailedMessage",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("DetailedMessage", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<DetailedMessage>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                unicode: false);
            detailedMessage.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var elapsedMilliseconds = runtimeEntityType.AddProperty(
                "ElapsedMilliseconds",
                typeof(double?),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("ElapsedMilliseconds", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<ElapsedMilliseconds>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            elapsedMilliseconds.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var httpStatusCode = runtimeEntityType.AddProperty(
                "HttpStatusCode",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("HttpStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<HttpStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            httpStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var ipaddress = runtimeEntityType.AddProperty(
                "Ipaddress",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("Ipaddress", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<Ipaddress>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20,
                unicode: false);
            ipaddress.AddAnnotation("Relational:ColumnName", "IPAddress");
            ipaddress.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var level = runtimeEntityType.AddProperty(
                "Level",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("Level", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<Level>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            level.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var machineName = runtimeEntityType.AddProperty(
                "MachineName",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("MachineName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<MachineName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            machineName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var message = runtimeEntityType.AddProperty(
                "Message",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("Message", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<Message>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            message.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestBody = runtimeEntityType.AddProperty(
                "RequestBody",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("RequestBody", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<RequestBody>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            requestBody.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestHeaders = runtimeEntityType.AddProperty(
                "RequestHeaders",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("RequestHeaders", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<RequestHeaders>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            requestHeaders.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestId = runtimeEntityType.AddProperty(
                "RequestId",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("RequestId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<RequestId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            requestId.AddAnnotation("Relational:ColumnName", "RequestID");
            requestId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestParameters = runtimeEntityType.AddProperty(
                "RequestParameters",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("RequestParameters", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<RequestParameters>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 4000);
            requestParameters.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestPath = runtimeEntityType.AddProperty(
                "RequestPath",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("RequestPath", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<RequestPath>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 1000,
                unicode: false);
            requestPath.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var timeStamp = runtimeEntityType.AddProperty(
                "TimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("TimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<TimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            timeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            timeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userAgent = runtimeEntityType.AddProperty(
                "UserAgent",
                typeof(string),
                propertyInfo: typeof(WebApiRequestsLog).GetProperty("UserAgent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(WebApiRequestsLog).GetField("<UserAgent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 300,
                unicode: false);
            userAgent.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "WebApi_RequestsLog");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
