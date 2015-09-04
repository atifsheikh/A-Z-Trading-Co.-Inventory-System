// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ItemJson.json"
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

using __ItItemsEle2__ = global::ItemJson.ItemsElementJson.Input;
using __ItemJson1__ = global::ItemJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::ItemJson.ItemsElementJson>;
using __IItBALANCE___ = global::ItemJson.ItemsElementJson.Input.BALANCE_LIMIT;
using __IItAMOUNT__ = global::ItemJson.ItemsElementJson.Input.AMOUNT;
using __IItOPENING___ = global::ItemJson.ItemsElementJson.Input.OPENING_BALANCE;
using __IItEMAIL__ = global::ItemJson.ItemsElementJson.Input.EMAIL;
using __IItPHONE__ = global::ItemJson.ItemsElementJson.Input.PHONE;
using __IItADDRESS__ = global::ItemJson.ItemsElementJson.Input.ADDRESS;
using __IItNAME__ = global::ItemJson.ItemsElementJson.Input.NAME;
using __Arr__ = global::Starcounter.Arr<global::ItemJson.ItemsElementJson>;
using __ItemJson2__ = global::ItemJson.Input;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __IItSchema__ = global::ItemJson.ItemsElementJson.JsonByExample.Schema;
using __ItItemsEle__ = global::ItemJson.ItemsElementJson;
using __ItSchema__ = global::ItemJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ItemJson__ = global::ItemJson;
using __ItItemsEle1__ = global::ItemJson.ItemsElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ItemJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ItSchema__ DefaultTemplate = new __ItSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ItemJson(__ItSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ItSchema__ Template { get { return (__ItSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Items__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ItemJson__);
                ClassName = "ItemJson";
                Properties.ClearExposed();
                Items = Add<__TArray__>("Items");
                Items.SetCustomGetElementType((arr) => { return __ItItemsEle__.DefaultTemplate;});
                Items.SetCustomAccessors((_p_) => { return ((__ItemJson__)_p_).__bf__Items__; }, (_p_, _v_) => { ((__ItemJson__)_p_).__bf__Items__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ItemJson__(this) { Parent = parent }; }
            public __TArray__ Items;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Items {
#line 11 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.Items.Getter(this); }
#line 11 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.Items.Setter(this, value); } }
#line default

    
    #line hidden
    public class ItemsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __IItSchema__ DefaultTemplate = new __IItSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemsElementJson(__IItSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __IItSchema__ Template { get { return (__IItSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__NAME__;
        private System.String __bf__ADDRESS__;
        private System.String __bf__PHONE__;
        private System.String __bf__EMAIL__;
        private System.Int64 __bf__OPENING_BALANCE__;
        private System.Int64 __bf__AMOUNT__;
        private System.Int64 __bf__BALANCE_LIMIT__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ItItemsEle__);
                    ClassName = "ItemsElementJson";
                    Properties.ClearExposed();
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    OPENING_BALANCE = Add<__TLong__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0L;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__OPENING_BALANCE__ = (System.Int64)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    BALANCE_LIMIT = Add<__TLong__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0L;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__ItItemsEle__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__ItItemsEle__)_p_).__bf__BALANCE_LIMIT__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ItItemsEle__(this) { Parent = parent }; }
                public __TString__ NAME;
                public __TString__ ADDRESS;
                public __TString__ PHONE;
                public __TString__ EMAIL;
                public __TLong__ OPENING_BALANCE;
                public __TLong__ AMOUNT;
                public __TLong__ BALANCE_LIMIT;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 3 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 3 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 4 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 4 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 5 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 5 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 6 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 6 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OPENING_BALANCE {
#line 7 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 7 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 8 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 8 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BALANCE_LIMIT {
#line 10 "Server\Partials\ItemJson.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 10 "Server\Partials\ItemJson.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class NAME : Input<__ItItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ADDRESS : Input<__ItItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PHONE : Input<__ItItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class EMAIL : Input<__ItItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class OPENING_BALANCE : Input<__ItItemsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__ItItemsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class BALANCE_LIMIT : Input<__ItItemsEle__, __TLong__, long> {
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