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
    public partial class PaymentNotificationEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.PaymentNotification",
                typeof(PaymentNotification),
                baseEntityType,
                propertyCount: 9,
                keyCount: 1);

            var notificationId = runtimeEntityType.AddProperty(
                "NotificationId",
                typeof(int),
                propertyInfo: typeof(PaymentNotification).GetProperty("NotificationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<NotificationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            notificationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var callbackStatus = runtimeEntityType.AddProperty(
                "CallbackStatus",
                typeof(int?),
                propertyInfo: typeof(PaymentNotification).GetProperty("CallbackStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<CallbackStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            callbackStatus.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var evgpaymentReference = runtimeEntityType.AddProperty(
                "EvgpaymentReference",
                typeof(string),
                propertyInfo: typeof(PaymentNotification).GetProperty("EvgpaymentReference", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<EvgpaymentReference>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            evgpaymentReference.AddAnnotation("Relational:ColumnName", "EVGPaymentReference");
            evgpaymentReference.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var notificationType = runtimeEntityType.AddProperty(
                "NotificationType",
                typeof(int?),
                propertyInfo: typeof(PaymentNotification).GetProperty("NotificationType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<NotificationType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            notificationType.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var paymentStatus = runtimeEntityType.AddProperty(
                "PaymentStatus",
                typeof(int?),
                propertyInfo: typeof(PaymentNotification).GetProperty("PaymentStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<PaymentStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            paymentStatus.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rejectionReason = runtimeEntityType.AddProperty(
                "RejectionReason",
                typeof(string),
                propertyInfo: typeof(PaymentNotification).GetProperty("RejectionReason", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<RejectionReason>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rejectionReason.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var responseCode = runtimeEntityType.AddProperty(
                "ResponseCode",
                typeof(int?),
                propertyInfo: typeof(PaymentNotification).GetProperty("ResponseCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<ResponseCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            responseCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var responseDescription = runtimeEntityType.AddProperty(
                "ResponseDescription",
                typeof(string),
                propertyInfo: typeof(PaymentNotification).GetProperty("ResponseDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<ResponseDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            responseDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var transactionDateTime = runtimeEntityType.AddProperty(
                "TransactionDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(PaymentNotification).GetProperty("TransactionDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentNotification).GetField("<TransactionDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            transactionDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            transactionDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { notificationId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__PaymentN__20CF2E12B66493EC");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PaymentNotifications");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
