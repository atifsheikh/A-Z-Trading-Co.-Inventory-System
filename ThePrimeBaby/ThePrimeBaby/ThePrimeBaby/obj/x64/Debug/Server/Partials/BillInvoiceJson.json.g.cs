// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\BillInvoiceJson.json"
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

using __BiInvoiceD1__ = global::BillInvoiceJson.InvoiceDetailsJson.JsonByExample;
using __BInCustomer2__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input;
using __BICuID__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input.ID;
using __BICuNAME__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input.NAME;
using __BICuEMAIL__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input.EMAIL;
using __BICuPHONE__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input.PHONE;
using __BICuADDRESS__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input.ADDRESS;
using __BICuAMOUNT__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input.AMOUNT;
using __BICuOPENING___ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input.OPENING_BALANCE;
using __BICuBALANCE___ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.Input.BALANCE_LIMIT;
using __BInCustomer1__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.JsonByExample;
using __BInBillJson__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson;
using __BInBillJson2__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.Input;
using __BIBiID__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.Input.ID;
using __BIBiNAME1__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.Input.NAME;
using __BIBiDATED__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.Input.DATED;
using __BIBiAMOUNT__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.Input.AMOUNT;
using __BIBiREMARKS__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.Input.REMARKS;
using __BIBiCUSTOMER__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.Input.CUSTOMER_BALANCE;
using __BIBiTOTAL_CT__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.Input.TOTAL_CTN;
using __Arr__ = global::Starcounter.Arr<global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson>;
using __BInBillJson1__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.JsonByExample;
using __BInCustomer__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson;
using __BillInvo2__ = global::BillInvoiceJson.Input;
using __BiInvoiceD__ = global::BillInvoiceJson.InvoiceDetailsJson;
using __BillInvo__ = global::BillInvoiceJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __BiSchema__ = global::BillInvoiceJson.JsonByExample.Schema;
using __BInSchema__ = global::BillInvoiceJson.InvoiceDetailsJson.JsonByExample.Schema;
using __BICuSchema__ = global::BillInvoiceJson.InvoiceDetailsJson.CustomerJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __BIBiSchema__ = global::BillInvoiceJson.InvoiceDetailsJson.BillJson.JsonByExample.Schema;
using __BInBillDeta__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson;
using __BIBiSchema1__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson.JsonByExample.Schema;
using __BInBillDeta1__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson.JsonByExample;
using __BInBillDeta2__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson.Input;
using __BIBiNAME__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson.Input.NAME;
using __BIBiMODEL__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson.Input.MODEL;
using __BIBiT_QUANTI__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson.Input.T_QUANTITY;
using __BIBiPRICE__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson.Input.PRICE;
using __BIBiSUBTOTAL__ = global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson.Input.SUBTOTAL;
using __TArray__ = global::Starcounter.Templates.TArray<global::BillInvoiceJson.InvoiceDetailsJson.BillDetailElementJson>;
using __BillInvo1__ = global::BillInvoiceJson.JsonByExample;
using __BiInvoiceD2__ = global::BillInvoiceJson.InvoiceDetailsJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class BillInvoiceJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BiSchema__ DefaultTemplate = new __BiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BillInvoiceJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BillInvoiceJson(__BiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BiSchema__ Template { get { return (__BiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __BiInvoiceD__ __bf__InvoiceDetails__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__BillInvo__);
                ClassName = "BillInvoiceJson";
                Properties.ClearExposed();
                InvoiceDetails = Add<__BInSchema__>("InvoiceDetails");
                InvoiceDetails.SetCustomAccessors((_p_) => { return ((__BillInvo__)_p_).__bf__InvoiceDetails__; }, (_p_, _v_) => { ((__BillInvo__)_p_).__bf__InvoiceDetails__ = (__BiInvoiceD__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __BillInvo__(this) { Parent = parent }; }
            public __BInSchema__ InvoiceDetails;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __BiInvoiceD__ InvoiceDetails {
#line 32 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return (__BiInvoiceD__)Template.InvoiceDetails.Getter(this); }
#line 32 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.InvoiceDetails.Setter(this, value); } }
#line default

    
    #line hidden
    public class InvoiceDetailsJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __BInSchema__ DefaultTemplate = new __BInSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public InvoiceDetailsJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public InvoiceDetailsJson(__BInSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __BInSchema__ Template { get { return (__BInSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private __BInCustomer__ __bf__Customer__;
        private __BInBillJson__ __bf__Bill__;
        private __Arr__ __bf__BillDetail__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__BiInvoiceD__);
                    ClassName = "InvoiceDetailsJson";
                    Properties.ClearExposed();
                    Customer = Add<__BICuSchema__>("Customer");
                    Customer.SetCustomAccessors((_p_) => { return ((__BiInvoiceD__)_p_).__bf__Customer__; }, (_p_, _v_) => { ((__BiInvoiceD__)_p_).__bf__Customer__ = (__BInCustomer__)_v_; }, false);
                    Bill = Add<__BIBiSchema__>("Bill");
                    Bill.SetCustomAccessors((_p_) => { return ((__BiInvoiceD__)_p_).__bf__Bill__; }, (_p_, _v_) => { ((__BiInvoiceD__)_p_).__bf__Bill__ = (__BInBillJson__)_v_; }, false);
                    BillDetail = Add<__TArray__>("BillDetail");
                    BillDetail.SetCustomGetElementType((arr) => { return __BInBillDeta__.DefaultTemplate;});
                    BillDetail.SetCustomAccessors((_p_) => { return ((__BiInvoiceD__)_p_).__bf__BillDetail__; }, (_p_, _v_) => { ((__BiInvoiceD__)_p_).__bf__BillDetail__ = (__Arr__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __BiInvoiceD__(this) { Parent = parent }; }
                public __BICuSchema__ Customer;
                public __BIBiSchema__ Bill;
                public __TArray__ BillDetail;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __BInCustomer__ Customer {
#line 12 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return (__BInCustomer__)Template.Customer.Getter(this); }
#line 12 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.Customer.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __BInBillJson__ Bill {
#line 21 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return (__BInBillJson__)Template.Bill.Getter(this); }
#line 21 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.Bill.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr__ BillDetail {
#line 31 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.BillDetail.Getter(this); }
#line 31 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.BillDetail.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class CustomerJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __BICuSchema__ DefaultTemplate = new __BICuSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public CustomerJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public CustomerJson(__BICuSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __BICuSchema__ Template { get { return (__BICuSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.Int64 __bf__ID__;
            private System.String __bf__NAME__;
            private System.String __bf__EMAIL__;
            private System.String __bf__PHONE__;
            private System.String __bf__ADDRESS__;
            private System.Int64 __bf__AMOUNT__;
            private System.Int64 __bf__OPENING_BALANCE__;
            private System.Int64 __bf__BALANCE_LIMIT__;
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__BInCustomer__);
                        ClassName = "CustomerJson";
                        Properties.ClearExposed();
                        ID = Add<__TLong__>("ID");
                        ID.DefaultValue = 0L;
                        ID.SetCustomAccessors((_p_) => { return ((__BInCustomer__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BInCustomer__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        NAME = Add<__TString__>("NAME");
                        NAME.DefaultValue = "";
                        NAME.SetCustomAccessors((_p_) => { return ((__BInCustomer__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BInCustomer__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                        EMAIL = Add<__TString__>("EMAIL");
                        EMAIL.DefaultValue = "";
                        EMAIL.SetCustomAccessors((_p_) => { return ((__BInCustomer__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__BInCustomer__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                        PHONE = Add<__TString__>("PHONE");
                        PHONE.DefaultValue = "";
                        PHONE.SetCustomAccessors((_p_) => { return ((__BInCustomer__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__BInCustomer__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                        ADDRESS = Add<__TString__>("ADDRESS");
                        ADDRESS.DefaultValue = "";
                        ADDRESS.SetCustomAccessors((_p_) => { return ((__BInCustomer__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__BInCustomer__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                        AMOUNT = Add<__TLong__>("AMOUNT");
                        AMOUNT.DefaultValue = 0L;
                        AMOUNT.SetCustomAccessors((_p_) => { return ((__BInCustomer__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__BInCustomer__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                        OPENING_BALANCE = Add<__TLong__>("OPENING_BALANCE");
                        OPENING_BALANCE.DefaultValue = 0L;
                        OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__BInCustomer__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__BInCustomer__)_p_).__bf__OPENING_BALANCE__ = (System.Int64)_v_; }, false);
                        BALANCE_LIMIT = Add<__TLong__>("BALANCE_LIMIT");
                        BALANCE_LIMIT.DefaultValue = 0L;
                        BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__BInCustomer__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__BInCustomer__)_p_).__bf__BALANCE_LIMIT__ = (System.Int64)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __BInCustomer__(this) { Parent = parent }; }
                    public __TLong__ ID;
                    public __TString__ NAME;
                    public __TString__ EMAIL;
                    public __TString__ PHONE;
                    public __TString__ ADDRESS;
                    public __TLong__ AMOUNT;
                    public __TLong__ OPENING_BALANCE;
                    public __TLong__ BALANCE_LIMIT;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ID {
#line 4 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 4 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String NAME {
#line 5 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 5 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String EMAIL {
#line 6 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 6 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String PHONE {
#line 7 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 7 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String ADDRESS {
#line 8 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 8 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 AMOUNT {
#line 9 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 9 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 OPENING_BALANCE {
#line 10 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 10 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 BALANCE_LIMIT {
#line 12 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 12 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class ID : Input<__BInCustomer__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class NAME : Input<__BInCustomer__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class EMAIL : Input<__BInCustomer__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class PHONE : Input<__BInCustomer__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class ADDRESS : Input<__BInCustomer__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class AMOUNT : Input<__BInCustomer__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class OPENING_BALANCE : Input<__BInCustomer__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class BALANCE_LIMIT : Input<__BInCustomer__, __TLong__, long> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class BillJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __BIBiSchema__ DefaultTemplate = new __BIBiSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public BillJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public BillJson(__BIBiSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __BIBiSchema__ Template { get { return (__BIBiSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.Int64 __bf__ID__;
            private System.String __bf__NAME__;
            private System.String __bf__DATED__;
            private System.Int64 __bf__AMOUNT__;
            private System.String __bf__REMARKS__;
            private System.Int64 __bf__CUSTOMER_BALANCE__;
            private System.Int64 __bf__TOTAL_CTN__;
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__BInBillJson__);
                        ClassName = "BillJson";
                        Properties.ClearExposed();
                        ID = Add<__TLong__>("ID");
                        ID.DefaultValue = 0L;
                        ID.SetCustomAccessors((_p_) => { return ((__BInBillJson__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BInBillJson__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                        NAME = Add<__TString__>("NAME");
                        NAME.DefaultValue = "";
                        NAME.SetCustomAccessors((_p_) => { return ((__BInBillJson__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BInBillJson__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                        DATED = Add<__TString__>("DATED");
                        DATED.DefaultValue = "";
                        DATED.SetCustomAccessors((_p_) => { return ((__BInBillJson__)_p_).__bf__DATED__; }, (_p_, _v_) => { ((__BInBillJson__)_p_).__bf__DATED__ = (System.String)_v_; }, false);
                        AMOUNT = Add<__TLong__>("AMOUNT");
                        AMOUNT.DefaultValue = 0L;
                        AMOUNT.SetCustomAccessors((_p_) => { return ((__BInBillJson__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__BInBillJson__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                        REMARKS = Add<__TString__>("REMARKS");
                        REMARKS.DefaultValue = "";
                        REMARKS.SetCustomAccessors((_p_) => { return ((__BInBillJson__)_p_).__bf__REMARKS__; }, (_p_, _v_) => { ((__BInBillJson__)_p_).__bf__REMARKS__ = (System.String)_v_; }, false);
                        CUSTOMER_BALANCE = Add<__TLong__>("CUSTOMER_BALANCE");
                        CUSTOMER_BALANCE.DefaultValue = 0L;
                        CUSTOMER_BALANCE.SetCustomAccessors((_p_) => { return ((__BInBillJson__)_p_).__bf__CUSTOMER_BALANCE__; }, (_p_, _v_) => { ((__BInBillJson__)_p_).__bf__CUSTOMER_BALANCE__ = (System.Int64)_v_; }, false);
                        TOTAL_CTN = Add<__TLong__>("TOTAL_CTN");
                        TOTAL_CTN.DefaultValue = 0L;
                        TOTAL_CTN.SetCustomAccessors((_p_) => { return ((__BInBillJson__)_p_).__bf__TOTAL_CTN__; }, (_p_, _v_) => { ((__BInBillJson__)_p_).__bf__TOTAL_CTN__ = (System.Int64)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __BInBillJson__(this) { Parent = parent }; }
                    public __TLong__ ID;
                    public __TString__ NAME;
                    public __TString__ DATED;
                    public __TLong__ AMOUNT;
                    public __TString__ REMARKS;
                    public __TLong__ CUSTOMER_BALANCE;
                    public __TLong__ TOTAL_CTN;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ID {
#line 14 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 14 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String NAME {
#line 15 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 15 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String DATED {
#line 16 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.DATED.Getter(this); }
#line 16 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.DATED.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 AMOUNT {
#line 17 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 17 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String REMARKS {
#line 18 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.REMARKS.Getter(this); }
#line 18 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.REMARKS.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 CUSTOMER_BALANCE {
#line 19 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.CUSTOMER_BALANCE.Getter(this); }
#line 19 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.CUSTOMER_BALANCE.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 TOTAL_CTN {
#line 21 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.TOTAL_CTN.Getter(this); }
#line 21 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.TOTAL_CTN.Setter(this, value); } }
#line default

            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class ID : Input<__BInBillJson__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class NAME : Input<__BInBillJson__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class DATED : Input<__BInBillJson__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class AMOUNT : Input<__BInBillJson__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class REMARKS : Input<__BInBillJson__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class CUSTOMER_BALANCE : Input<__BInBillJson__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class TOTAL_CTN : Input<__BInBillJson__, __TLong__, long> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class BillDetailElementJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __BIBiSchema1__ DefaultTemplate = new __BIBiSchema1__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public BillDetailElementJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public BillDetailElementJson(__BIBiSchema1__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __BIBiSchema1__ Template { get { return (__BIBiSchema1__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.String __bf__NAME__;
            private System.String __bf__MODEL__;
            private System.Int64 __bf__T_QUANTITY__;
            private System.Int64 __bf__PRICE__;
            private System.Int64 __bf__SUBTOTAL__;
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__BInBillDeta__);
                        ClassName = "BillDetailElementJson";
                        Properties.ClearExposed();
                        NAME = Add<__TString__>("NAME");
                        NAME.DefaultValue = "";
                        NAME.SetCustomAccessors((_p_) => { return ((__BInBillDeta__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BInBillDeta__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                        MODEL = Add<__TString__>("MODEL");
                        MODEL.DefaultValue = "";
                        MODEL.SetCustomAccessors((_p_) => { return ((__BInBillDeta__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__BInBillDeta__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                        T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                        T_QUANTITY.DefaultValue = 0L;
                        T_QUANTITY.SetCustomAccessors((_p_) => { return ((__BInBillDeta__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__BInBillDeta__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                        PRICE = Add<__TLong__>("PRICE");
                        PRICE.DefaultValue = 0L;
                        PRICE.SetCustomAccessors((_p_) => { return ((__BInBillDeta__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__BInBillDeta__)_p_).__bf__PRICE__ = (System.Int64)_v_; }, false);
                        SUBTOTAL = Add<__TLong__>("SUBTOTAL");
                        SUBTOTAL.DefaultValue = 0L;
                        SUBTOTAL.SetCustomAccessors((_p_) => { return ((__BInBillDeta__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__BInBillDeta__)_p_).__bf__SUBTOTAL__ = (System.Int64)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __BInBillDeta__(this) { Parent = parent }; }
                    public __TString__ NAME;
                    public __TString__ MODEL;
                    public __TLong__ T_QUANTITY;
                    public __TLong__ PRICE;
                    public __TLong__ SUBTOTAL;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String NAME {
#line 24 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 24 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String MODEL {
#line 25 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 25 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 T_QUANTITY {
#line 26 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 26 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 PRICE {
#line 27 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 27 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 SUBTOTAL {
#line 29 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 29 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
#line default

            
            #line hidden
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class NAME : Input<__BInBillDeta__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class MODEL : Input<__BInBillDeta__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class T_QUANTITY : Input<__BInBillDeta__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class PRICE : Input<__BInBillDeta__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class SUBTOTAL : Input<__BInBillDeta__, __TLong__, long> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
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