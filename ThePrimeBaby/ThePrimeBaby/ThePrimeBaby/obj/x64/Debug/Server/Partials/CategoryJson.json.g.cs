// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\CategoryJson.json"
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using st=Starcounter.Templates;
using s=Starcounter;
using _GEN1_=System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_=System.CodeDom.Compiler.GeneratedCodeAttribute;
using _ScTemplate_=Starcounter.Templates.Template;
#pragma warning disable 0108
#pragma warning disable 1591

using __TLong__ = global::Starcounter.Templates.TLong;
using __Category1__ = global::CategoryJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::CategoryJson.CategoriesElementJson>;
using __CCaName__ = global::CategoryJson.CategoriesElementJson.Input.Name;
using __CCaID__ = global::CategoryJson.CategoriesElementJson.Input.ID;
using __CaCategori2__ = global::CategoryJson.CategoriesElementJson.Input;
using __CaCategori1__ = global::CategoryJson.CategoriesElementJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __Category2__ = global::CategoryJson.Input;
using __CCaSchema__ = global::CategoryJson.CategoriesElementJson.JsonByExample.Schema;
using __CaCategori__ = global::CategoryJson.CategoriesElementJson;
using __CaSchema__ = global::CategoryJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Category__ = global::CategoryJson;
using __Arr__ = global::Starcounter.Arr<global::CategoryJson.CategoriesElementJson>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CategoryJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CaSchema__ DefaultTemplate = new __CaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CategoryJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CategoryJson(__CaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CaSchema__ Template { get { return (__CaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Categories__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Category__);
                ClassName = "CategoryJson";
                Properties.ClearExposed();
                Categories = Add<__TArray__>("Categories");
                Categories.SetCustomGetElementType((arr) => { return __CaCategori__.DefaultTemplate;});
                Categories.SetCustomAccessors((_p_) => { return ((__Category__)_p_).__bf__Categories__; }, (_p_, _v_) => { ((__Category__)_p_).__bf__Categories__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Category__(this) { Parent = parent }; }
            public __TArray__ Categories;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Categories {
#line 6 "Server\Partials\CategoryJson.json"
    get {
#line hidden
        return Template.Categories.Getter(this); }
#line 6 "Server\Partials\CategoryJson.json"
    set {
#line hidden
        Template.Categories.Setter(this, value); } }
#line default

    
    #line hidden
    public class CategoriesElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCaSchema__ DefaultTemplate = new __CCaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CategoriesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CategoriesElementJson(__CCaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCaSchema__ Template { get { return (__CCaSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__Name__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CaCategori__);
                    ClassName = "CategoriesElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__CaCategori__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__CaCategori__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    Name = Add<__TString__>("Name");
                    Name.DefaultValue = "";
                    Name.SetCustomAccessors((_p_) => { return ((__CaCategori__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__CaCategori__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CaCategori__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ Name;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\CategoryJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\CategoryJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 5 "Server\Partials\CategoryJson.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 5 "Server\Partials\CategoryJson.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__CaCategori__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class Name : Input<__CaCategori__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public static class Input {
    }
    #line default
}
#line default
#pragma warning restore 1591
#pragma warning restore 0108