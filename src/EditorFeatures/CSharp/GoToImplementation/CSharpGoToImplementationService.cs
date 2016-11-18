﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Composition;
using Microsoft.CodeAnalysis.Editor.GoToImplementation;
using Microsoft.CodeAnalysis.Editor.Host;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.Editor.CSharp.GoToImplementation
{
    [ExportLanguageService(typeof(IGoToImplementationService), LanguageNames.CSharp), Shared]
    internal sealed class CSharpGoToImplementationService : AbstractGoToImplementationService
    {
        [ImportingConstructor]
        public CSharpGoToImplementationService(
            [ImportMany]IEnumerable<Lazy<INavigableItemsPresenter>> presenters) 
            : base(presenters)
        {
        }
    }

    [ExportLanguageService(typeof(IStreamingFindImplementationsService), LanguageNames.CSharp), Shared]
    internal sealed class CSharpStreamingFindImplementationsService : AbstractGoToImplementationService
    {
        [ImportingConstructor]
        public CSharpStreamingFindImplementationsService(
            [ImportMany]IEnumerable<Lazy<INavigableItemsPresenter>> presenters)
            : base(presenters)
        {
        }
    }
}
