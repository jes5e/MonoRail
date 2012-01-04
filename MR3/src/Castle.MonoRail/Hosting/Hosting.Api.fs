﻿//  Copyright 2004-2012 Castle Project - http://www.castleproject.org/
//  Hamilton Verissimo de Oliveira and individual contributors as indicated. 
//  See the committers.txt/contributors.txt in the distribution for a 
//  full listing of individual contributors.
// 
//  This is free software; you can redistribute it and/or modify it
//  under the terms of the GNU Lesser General Public License as
//  published by the Free Software Foundation; either version 3 of
//  the License, or (at your option) any later version.
// 
//  You should have received a copy of the GNU Lesser General Public
//  License along with this software; if not, write to the Free
//  Software Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
//  02110-1301 USA, or see the FSF site: http://www.fsf.org.

namespace Castle.MonoRail.Hosting

    open System.Web
    open System.Web.SessionState
    open System.ComponentModel.Composition

    [<Interface; AllowNullLiteral>]
    type IComposableHandler =
        abstract member TryProcessRequest : request:HttpContextBase -> bool
        
    [<AbstractClass; AllowNullLiteral>]
    type ComposableHandler() =

        abstract member TryProcessRequest : request:HttpContextBase -> bool

        interface IComposableHandler with
            // funny way to define abstract members associated with interfaces
            member x.TryProcessRequest (request:HttpContextBase) = x.TryProcessRequest(request)      


    type IDeploymentInfo = 
        interface
            abstract member FSPathOffset : string with get
        end
        

