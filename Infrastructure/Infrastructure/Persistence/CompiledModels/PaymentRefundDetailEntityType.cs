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
    public partial class PaymentRefundDetailEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.PaymentRefundDetail",
                typeof(PaymentRefundDetail),
                baseEntityType,
                propertyCount: 6,
                navigationCount: 2,
                foreignKeyCount: 2,
                unnamedIndexCount: 2,
                keyCount: 1);

            var paymentRefundDetails = runtimeEntityType.AddProperty(
                "PaymentRefundDetails",
                typeof(long),
                propertyInfo: typeof(PaymentRefundDetail).GetProperty("PaymentRefundDetails", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRefundDetail).GetField("<PaymentRefundDetails>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            paymentRefundDetails.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var comments = runtimeEntityType.AddProperty(
                "Comments",
                typeof(string),
                propertyInfo: typeof(PaymentRefundDetail).GetProperty("Comments", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRefundDetail).GetField("<Comments>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            comments.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdDate = runtimeEntityType.AddProperty(
                "CreatedDate",
                typeof(DateTime),
                propertyInfo: typeof(PaymentRefundDetail).GetProperty("CreatedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRefundDetail).GetField("<CreatedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createdDate.AddAnnotation("Relational:ColumnType", "datetime");
            createdDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var paymentTransactionId = runtimeEntityType.AddProperty(
                "PaymentTransactionId",
                typeof(long),
                propertyInfo: typeof(PaymentRefundDetail).GetProperty("PaymentTransactionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRefundDetail).GetField("<PaymentTransactionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            paymentTransactionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var refundDate = runtimeEntityType.AddProperty(
                "RefundDate",
                typeof(DateTime?),
                propertyInfo: typeof(PaymentRefundDetail).GetProperty("RefundDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRefundDetail).GetField("<RefundDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refundDate.AddAnnotation("Relational:ColumnType", "datetime");
            refundDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var refundStatusId = runtimeEntityType.AddProperty(
                "RefundStatusId",
                typeof(int?),
                propertyInfo: typeof(PaymentRefundDetail).GetProperty("RefundStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRefundDetail).GetField("<RefundStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            refundStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { paymentRefundDetails });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { paymentTransactionId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { refundStatusId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PaymentTransactionId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("TransactionId") }),
                principalEntityType,
                required: true);

            var paymentTransaction = declaringEntityType.AddNavigation("PaymentTransaction",
                runtimeForeignKey,
                onDependent: true,
                typeof(PaymentTransaction),
                propertyInfo: typeof(PaymentRefundDetail).GetProperty("PaymentTransaction", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRefundDetail).GetField("<PaymentTransaction>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var paymentRefundDetails = principalEntityType.AddNavigation("PaymentRefundDetails",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PaymentRefundDetail>),
                propertyInfo: typeof(PaymentTransaction).GetProperty("PaymentRefundDetails", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentTransaction).GetField("<PaymentRefundDetails>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PaymentRefundDetails_PaymentTransactions");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RefundStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType);

            var refundStatus = declaringEntityType.AddNavigation("RefundStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(PaymentRequestStatusDim),
                propertyInfo: typeof(PaymentRefundDetail).GetProperty("RefundStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRefundDetail).GetField("<RefundStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var paymentRefundDetails = principalEntityType.AddNavigation("PaymentRefundDetails",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PaymentRefundDetail>),
                propertyInfo: typeof(PaymentRequestStatusDim).GetProperty("PaymentRefundDetails", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PaymentRequestStatusDim).GetField("<PaymentRefundDetails>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PaymentRefundDetails_PaymentRequestStatusDim");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PaymentRefundDetails");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
