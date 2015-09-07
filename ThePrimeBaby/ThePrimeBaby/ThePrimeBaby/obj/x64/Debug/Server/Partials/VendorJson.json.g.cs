// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\VendorJson.json"
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

using __VeVendorsE2__ = global::VendorJson.VendorsElementJson.Input;
using __VendorJs1__ = global::VendorJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::VendorJson.VendorsElementJson>;
using __VVeBALANCE___ = global::VendorJson.VendorsElementJson.Input.BALANCE_LIMIT;
using __VVeAMOUNT__ = global::VendorJson.VendorsElementJson.Input.AMOUNT;
using __VVeOPENING___ = global::VendorJson.VendorsElementJson.Input.OPENING_BALANCE;
using __VVeEMAIL__ = global::VendorJson.VendorsElementJson.Input.EMAIL;
using __VVePHONE__ = global::VendorJson.VendorsElementJson.Input.PHONE;
using __VVeADDRESS__ = global::VendorJson.VendorsElementJson.Input.ADDRESS;
using __VVeNAME__ = global::VendorJson.VendorsElementJson.Input.NAME;
using __VVeID__ = global::VendorJson.VendorsElementJson.Input.ID;
using __VendorJs2__ = global::VendorJson.Input;
using __VeVendorsE1__ = global::VendorJson.VendorsElementJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __VVeSchema__ = global::VendorJson.VendorsElementJson.JsonByExample.Schema;
using __VeVendorsE__ = global::VendorJson.VendorsElementJson;
using __VeSchema__ = global::VendorJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __VendorJs__ = global::VendorJson;
using __Arr__ = global::Starcounter.Arr<global::VendorJson.VendorsElementJson>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class VendorJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __VeSchema__ DefaultTemplate = new __VeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public VendorJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public VendorJson(__VeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __VeSchema__ Template { get { return (__VeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Vendors__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__VendorJs__);
                ClassName = "VendorJson";
                Properties.ClearExposed();
                Vendors = Add<__TArray__>("Vendors");
                Vendors.SetCustomGetElementType((arr) => { return __VeVendorsE__.DefaultTemplate;});
                Vendors.SetCustomAccessors((_p_) => { return ((__VendorJs__)_p_).__bf__Vendors__; }, (_p_, _v_) => { ((__VendorJs__)_p_).__bf__Vendors__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __VendorJs__(this) { Parent = parent }; }
            public __TArray__ Vendors;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Vendors {
#line 12 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.Vendors.Getter(this); }
#line 12 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.Vendors.Setter(this, value); } }
#line default

    
    #line hidden
    public class VendorsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __VVeSchema__ DefaultTemplate = new __VVeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VendorsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VendorsElementJson(__VVeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __VVeSchema__ Template { get { return (__VVeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
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
                    InstanceType = typeof(__VeVendorsE__);
                    ClassName = "VendorsElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__VeVendorsE__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__VeVendorsE__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__VeVendorsE__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__VeVendorsE__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__VeVendorsE__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__VeVendorsE__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__VeVendorsE__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__VeVendorsE__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__VeVendorsE__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__VeVendorsE__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    OPENING_BALANCE = Add<__TLong__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0L;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__VeVendorsE__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__VeVendorsE__)_p_).__bf__OPENING_BALANCE__ = (System.Int64)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__VeVendorsE__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__VeVendorsE__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    BALANCE_LIMIT = Add<__TLong__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0L;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__VeVendorsE__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__VeVendorsE__)_p_).__bf__BALANCE_LIMIT__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __VeVendorsE__(this) { Parent = parent }; }
                public __TLong__ ID;
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
        public System.Int64 ID {
#line 3 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 4 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 5 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 5 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 6 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 6 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 7 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 7 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OPENING_BALANCE {
#line 8 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 8 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 9 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 9 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BALANCE_LIMIT {
#line 11 "Server\Partials\VendorJson.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 11 "Server\Partials\VendorJson.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__VeVendorsE__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__VeVendorsE__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ADDRESS : Input<__VeVendorsE__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PHONE : Input<__VeVendorsE__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class EMAIL : Input<__VeVendorsE__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class OPENING_BALANCE : Input<__VeVendorsE__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__VeVendorsE__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class BALANCE_LIMIT : Input<__VeVendorsE__, __TLong__, long> {
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