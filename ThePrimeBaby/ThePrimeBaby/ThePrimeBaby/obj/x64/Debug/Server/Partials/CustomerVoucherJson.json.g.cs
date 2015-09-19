// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\CustomerVoucherJson.json"
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

using __CCuCustomer__ = global::CustomerVoucherJson.CustomerVouchersElementJson.CustomerJson;
using __Customer1__ = global::CustomerVoucherJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::CustomerVoucherJson.CustomerVouchersElementJson>;
using __CCuREMARKS__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.REMARKS;
using __CCuDATED__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.DATED;
using __CCuCUSTOMER__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.CUSTOMER_BALANCE;
using __CCuAMOUNT__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.AMOUNT;
using __CCuID__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.ID;
using __CuCustomer2__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input;
using __CCCuNAME__ = global::CustomerVoucherJson.CustomerVouchersElementJson.CustomerJson.Input.NAME;
using __CCCuID__ = global::CustomerVoucherJson.CustomerVouchersElementJson.CustomerJson.Input.ID;
using __CCuCustomer2__ = global::CustomerVoucherJson.CustomerVouchersElementJson.CustomerJson.Input;
using __CCuCustomer1__ = global::CustomerVoucherJson.CustomerVouchersElementJson.CustomerJson.JsonByExample;
using __Customer2__ = global::CustomerVoucherJson.Input;
using __CuCustomer1__ = global::CustomerVoucherJson.CustomerVouchersElementJson.JsonByExample;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TString__ = global::Starcounter.Templates.TString;
using __CCCuSchema__ = global::CustomerVoucherJson.CustomerVouchersElementJson.CustomerJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __CCuSchema__ = global::CustomerVoucherJson.CustomerVouchersElementJson.JsonByExample.Schema;
using __CuCustomer__ = global::CustomerVoucherJson.CustomerVouchersElementJson;
using __CuSchema__ = global::CustomerVoucherJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Customer__ = global::CustomerVoucherJson;
using __Arr__ = global::Starcounter.Arr<global::CustomerVoucherJson.CustomerVouchersElementJson>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CustomerVoucherJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CuSchema__ DefaultTemplate = new __CuSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CustomerVoucherJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CustomerVoucherJson(__CuSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CuSchema__ Template { get { return (__CuSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__CustomerVouchers__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Customer__);
                ClassName = "CustomerVoucherJson";
                Properties.ClearExposed();
                CustomerVouchers = Add<__TArray__>("CustomerVouchers");
                CustomerVouchers.SetCustomGetElementType((arr) => { return __CuCustomer__.DefaultTemplate;});
                CustomerVouchers.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__CustomerVouchers__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__CustomerVouchers__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Customer__(this) { Parent = parent }; }
            public __TArray__ CustomerVouchers;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ CustomerVouchers {
#line 13 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.CustomerVouchers.Getter(this); }
#line 13 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.CustomerVouchers.Setter(this, value); } }
#line default

    
    #line hidden
    public class CustomerVouchersElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCuSchema__ DefaultTemplate = new __CCuSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerVouchersElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerVouchersElementJson(__CCuSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCuSchema__ Template { get { return (__CCuSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private __CCuCustomer__ __bf__Customer__;
        private System.Decimal __bf__AMOUNT__;
        private System.Decimal __bf__CUSTOMER_BALANCE__;
        private System.String __bf__DATED__;
        private System.String __bf__REMARKS__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CuCustomer__);
                    ClassName = "CustomerVouchersElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    Customer = Add<__CCCuSchema__>("Customer");
                    Customer.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__Customer__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__Customer__ = (__CCuCustomer__)_v_; }, false);
                    AMOUNT = Add<__TDecimal__>("AMOUNT");
                    AMOUNT.DefaultValue = 0.0m;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__AMOUNT__ = (System.Decimal)_v_; }, false);
                    CUSTOMER_BALANCE = Add<__TDecimal__>("CUSTOMER_BALANCE");
                    CUSTOMER_BALANCE.DefaultValue = 0.0m;
                    CUSTOMER_BALANCE.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__CUSTOMER_BALANCE__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__CUSTOMER_BALANCE__ = (System.Decimal)_v_; }, false);
                    DATED = Add<__TString__>("DATED");
                    DATED.DefaultValue = "";
                    DATED.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__DATED__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__DATED__ = (System.String)_v_; }, false);
                    REMARKS = Add<__TString__>("REMARKS");
                    REMARKS.DefaultValue = "";
                    REMARKS.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__REMARKS__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__REMARKS__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CuCustomer__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __CCCuSchema__ Customer;
                public __TDecimal__ AMOUNT;
                public __TDecimal__ CUSTOMER_BALANCE;
                public __TString__ DATED;
                public __TString__ REMARKS;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __CCuCustomer__ Customer {
#line 7 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return (__CCuCustomer__)Template.Customer.Getter(this); }
#line 7 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.Customer.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal AMOUNT {
#line 8 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 8 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal CUSTOMER_BALANCE {
#line 9 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.CUSTOMER_BALANCE.Getter(this); }
#line 9 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.CUSTOMER_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DATED {
#line 10 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.DATED.Getter(this); }
#line 10 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.DATED.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String REMARKS {
#line 12 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.REMARKS.Getter(this); }
#line 12 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.REMARKS.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class CustomerJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __CCCuSchema__ DefaultTemplate = new __CCCuSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public CustomerJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public CustomerJson(__CCCuSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __CCCuSchema__ Template { get { return (__CCCuSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.Int64 __bf__ID__;
            private System.String __bf__NAME__;
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__CCuCustomer__);
                        ClassName = "CustomerJson";
                        Properties.ClearExposed();
                        ID = Add<__TLong__>("ID");
                        ID.DefaultValue = 0L;
                        ID.SetCustomAccessors((_p_) => { return ((__CCuCustomer__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__CCuCustomer__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        NAME = Add<__TString__>("NAME");
                        NAME.DefaultValue = "";
                        NAME.SetCustomAccessors((_p_) => { return ((__CCuCustomer__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__CCuCustomer__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __CCuCustomer__(this) { Parent = parent }; }
                    public __TLong__ ID;
                    public __TString__ NAME;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ID {
#line 5 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 5 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String NAME {
#line 7 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 7 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class ID : Input<__CCuCustomer__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class NAME : Input<__CCuCustomer__, __TString__, string> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__CuCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__CuCustomer__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class CUSTOMER_BALANCE : Input<__CuCustomer__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class DATED : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class REMARKS : Input<__CuCustomer__, __TString__, string> {
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