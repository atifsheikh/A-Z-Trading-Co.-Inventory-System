// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\VendorVoucherJson.json"
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

using __VeVendorVo1__ = global::VendorVoucherJson.VendorVouchersElementJson.JsonByExample;
using __VendorVo1__ = global::VendorVoucherJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::VendorVoucherJson.VendorVouchersElementJson>;
using __VVeCUSTOMER__ = global::VendorVoucherJson.VendorVouchersElementJson.Input.CUSTOMER_BALANCE;
using __VVeREMARKS__ = global::VendorVoucherJson.VendorVouchersElementJson.Input.REMARKS;
using __VVeAMOUNT__ = global::VendorVoucherJson.VendorVouchersElementJson.Input.AMOUNT;
using __VVeVOUCHER___ = global::VendorVoucherJson.VendorVouchersElementJson.Input.VOUCHER_DATE;
using __VVeVendor__ = global::VendorVoucherJson.VendorVouchersElementJson.Input.Vendor;
using __VVeNAME__ = global::VendorVoucherJson.VendorVouchersElementJson.Input.NAME;
using __VVeID__ = global::VendorVoucherJson.VendorVouchersElementJson.Input.ID;
using __VeVendorVo2__ = global::VendorVoucherJson.VendorVouchersElementJson.Input;
using __VendorVo2__ = global::VendorVoucherJson.Input;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __VVeSchema__ = global::VendorVoucherJson.VendorVouchersElementJson.JsonByExample.Schema;
using __VeVendorVo__ = global::VendorVoucherJson.VendorVouchersElementJson;
using __VeSchema__ = global::VendorVoucherJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __VendorVo__ = global::VendorVoucherJson;
using __Arr__ = global::Starcounter.Arr<global::VendorVoucherJson.VendorVouchersElementJson>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class VendorVoucherJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __VeSchema__ DefaultTemplate = new __VeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public VendorVoucherJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public VendorVoucherJson(__VeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __VeSchema__ Template { get { return (__VeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__VendorVouchers__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__VendorVo__);
                ClassName = "VendorVoucherJson";
                Properties.ClearExposed();
                VendorVouchers = Add<__TArray__>("VendorVouchers");
                VendorVouchers.SetCustomGetElementType((arr) => { return __VeVendorVo__.DefaultTemplate;});
                VendorVouchers.SetCustomAccessors((_p_) => { return ((__VendorVo__)_p_).__bf__VendorVouchers__; }, (_p_, _v_) => { ((__VendorVo__)_p_).__bf__VendorVouchers__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __VendorVo__(this) { Parent = parent }; }
            public __TArray__ VendorVouchers;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ VendorVouchers {
#line 11 "Server\Partials\VendorVoucherJson.json"
    get {
#line hidden
        return Template.VendorVouchers.Getter(this); }
#line 11 "Server\Partials\VendorVoucherJson.json"
    set {
#line hidden
        Template.VendorVouchers.Setter(this, value); } }
#line default

    
    #line hidden
    public class VendorVouchersElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __VVeSchema__ DefaultTemplate = new __VVeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VendorVouchersElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VendorVouchersElementJson(__VVeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __VVeSchema__ Template { get { return (__VVeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.String __bf__Vendor__;
        private System.String __bf__VOUCHER_DATE__;
        private System.Decimal __bf__AMOUNT__;
        private System.String __bf__REMARKS__;
        private System.Decimal __bf__CUSTOMER_BALANCE__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__VeVendorVo__);
                    ClassName = "VendorVouchersElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__VeVendorVo__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__VeVendorVo__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__VeVendorVo__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__VeVendorVo__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    Vendor = Add<__TString__>("Vendor");
                    Vendor.DefaultValue = "";
                    Vendor.SetCustomAccessors((_p_) => { return ((__VeVendorVo__)_p_).__bf__Vendor__; }, (_p_, _v_) => { ((__VeVendorVo__)_p_).__bf__Vendor__ = (System.String)_v_; }, false);
                    VOUCHER_DATE = Add<__TString__>("VOUCHER_DATE");
                    VOUCHER_DATE.DefaultValue = "";
                    VOUCHER_DATE.SetCustomAccessors((_p_) => { return ((__VeVendorVo__)_p_).__bf__VOUCHER_DATE__; }, (_p_, _v_) => { ((__VeVendorVo__)_p_).__bf__VOUCHER_DATE__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TDecimal__>("AMOUNT");
                    AMOUNT.DefaultValue = 0.0m;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__VeVendorVo__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__VeVendorVo__)_p_).__bf__AMOUNT__ = (System.Decimal)_v_; }, false);
                    REMARKS = Add<__TString__>("REMARKS");
                    REMARKS.DefaultValue = "";
                    REMARKS.SetCustomAccessors((_p_) => { return ((__VeVendorVo__)_p_).__bf__REMARKS__; }, (_p_, _v_) => { ((__VeVendorVo__)_p_).__bf__REMARKS__ = (System.String)_v_; }, false);
                    CUSTOMER_BALANCE = Add<__TDecimal__>("CUSTOMER_BALANCE");
                    CUSTOMER_BALANCE.DefaultValue = 0.0m;
                    CUSTOMER_BALANCE.SetCustomAccessors((_p_) => { return ((__VeVendorVo__)_p_).__bf__CUSTOMER_BALANCE__; }, (_p_, _v_) => { ((__VeVendorVo__)_p_).__bf__CUSTOMER_BALANCE__ = (System.Decimal)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __VeVendorVo__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ Vendor;
                public __TString__ VOUCHER_DATE;
                public __TDecimal__ AMOUNT;
                public __TString__ REMARKS;
                public __TDecimal__ CUSTOMER_BALANCE;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\VendorVoucherJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\VendorVoucherJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 4 "Server\Partials\VendorVoucherJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\VendorVoucherJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Vendor {
#line 5 "Server\Partials\VendorVoucherJson.json"
    get {
#line hidden
        return Template.Vendor.Getter(this); }
#line 5 "Server\Partials\VendorVoucherJson.json"
    set {
#line hidden
        Template.Vendor.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String VOUCHER_DATE {
#line 6 "Server\Partials\VendorVoucherJson.json"
    get {
#line hidden
        return Template.VOUCHER_DATE.Getter(this); }
#line 6 "Server\Partials\VendorVoucherJson.json"
    set {
#line hidden
        Template.VOUCHER_DATE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal AMOUNT {
#line 7 "Server\Partials\VendorVoucherJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 7 "Server\Partials\VendorVoucherJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String REMARKS {
#line 8 "Server\Partials\VendorVoucherJson.json"
    get {
#line hidden
        return Template.REMARKS.Getter(this); }
#line 8 "Server\Partials\VendorVoucherJson.json"
    set {
#line hidden
        Template.REMARKS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal CUSTOMER_BALANCE {
#line 10 "Server\Partials\VendorVoucherJson.json"
    get {
#line hidden
        return Template.CUSTOMER_BALANCE.Getter(this); }
#line 10 "Server\Partials\VendorVoucherJson.json"
    set {
#line hidden
        Template.CUSTOMER_BALANCE.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__VeVendorVo__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__VeVendorVo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class Vendor : Input<__VeVendorVo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class VOUCHER_DATE : Input<__VeVendorVo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__VeVendorVo__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class REMARKS : Input<__VeVendorVo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CUSTOMER_BALANCE : Input<__VeVendorVo__, __TDecimal__, Decimal> {
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