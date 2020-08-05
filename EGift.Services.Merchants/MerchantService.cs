﻿using EGift.Services.Merchants.Data.Gateways;
using EGift.Services.Merchants.Exceptions;
using EGift.Services.Merchants.Extensions;
using EGift.Services.Merchants.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EGift.Services.Merchants
{
    public class MerchantService :IMerchantService
    {
        private readonly IMerchantGateway gateway;

        public MerchantService(IMerchantGateway gateway)
        {
            this.gateway = gateway;
        }

        public async Task<GetAllMerchantResponse> GetAllMerchantAsync()
        {
            GetAllMerchantResponse response;

            try
            {
                response = await this.gateway.GetAllMerchantAsync();
            }
            catch (Exception ex)
            {
                throw new MerchantServiceException(ex);
            }

            return response;
        }

        public async Task<GetMerchantProductResponse> GetMerchantProductsAsync(GetMerchantProductsRequest request)
        {
            GetMerchantProductResponse response;

            try
            {
                response = await this.gateway.GetMerchantProductsAsync(request.AsEntity());
            }
            catch (Exception ex)
            {
                throw new MerchantServiceException(ex);
            }

            return response;
        }
    }
}
