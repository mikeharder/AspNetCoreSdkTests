﻿namespace AspNetCoreSdkTests.Templates
{
    public class WebApiTemplate : WebTemplate
    {
        public new static WebApiTemplate Instance { get; } = new WebApiTemplate();

        protected WebApiTemplate() { }

        public override string Name => "webapi";
    }
}