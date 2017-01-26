
#region License, Terms and Conditions
//
// ProductService.Sync.cs
//
// Authors: Kori Francis <twitter.com/djbyter>, David Ball
// Copyright (C) 2010 Clinical Support Systems, Inc. All rights reserved.
// 
//  THIS FILE IS LICENSED UNDER THE MIT LICENSE AS OUTLINED IMMEDIATELY BELOW:
//
//  Permission is hereby granted, free of charge, to any person obtaining a
//  copy of this software and associated documentation files (the "Software"),
//  to deal in the Software without restriction, including without limitation
//  the rights to use, copy, modify, merge, publish, distribute, sublicense,
//  and/or sell copies of the Software, and to permit persons to whom the
//  Software is furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//  FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//  DEALINGS IN THE SOFTWARE.
//
#endregion

namespace Chargify
{
    #region Imports
    using System;
    using System.Collections.Generic;
    #endregion

    public static class ProductServiceSyncExtensions
    {
        public static IEnumerable<Product> All(this ProductService service)
        {
            string url = string.Format(format: "/{0}", arg0: ProductService.ProductKey);
            return service.GetRequest<List<Product>>(url);
        }

        public static IEnumerable<Product> All(this ProductService service, int familyId)
        {
            string url = string.Format(format: "/{0}/{1}/{2}", arg0: ProductFamilyService.ProductFamilyKey, arg1: familyId, arg2: ProductService.ProductKey);
            return service.GetRequest<List<Product>>(url);
        }

        public static Product Single(this ProductService service, int id)
        {
            string url = string.Format(format: "/{0}/{1}", arg0: ProductService.ProductKey, arg1: id);
            return service.GetRequest<Product>(url);
        }

        public static Product Single(this ProductService service, string handle)
        {
            string url = string.Format(format: "/{0}/handle/{1}", arg0: ProductService.ProductKey, arg1: handle);
            return service.GetRequest<Product>(url);
        }

        public static Product Create(this ProductService service, int familyId, Product product)
        {
            string url = string.Format(format: "/{0}/{1}/{2}", arg0: ProductFamilyService.ProductFamilyKey, arg1: familyId, arg2: ProductService.ProductKey);
            return service.PostRequest<Product, Product>(product, url);
        }

        public static void Archive(this ProductService service, Product product)
        {
            throw new NotImplementedException();
        }
    }
}