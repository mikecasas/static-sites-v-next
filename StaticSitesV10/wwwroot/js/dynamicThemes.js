export function setGlobalTheme(themeName) {
    
    let s = makeid(15);

    let L1Global = `css/themes/${themeName}/variables.css?v=${s}`;
    let L2Global = `css/themes/${themeName}/app.css?v=${s}`;     

    let VarLink = makeLink(GlobalVar, L1Global);
    let CssLink = makeLink(GlobalCss, L2Global);

    let head = document.getElementsByTagName("head")[0];

    console.log(GlobalVar);
    console.log(GlobalCss);


    head.querySelector("#" + GlobalVar).remove();
    head.querySelector("#" + GlobalCss).remove();

    console.log(head);
    console.log(VarLink);

    head.appendChild(VarLink);
    head.appendChild(CssLink);
}

export function setTenantTheme(tenantId) {

    let s = makeid(5);

    let L1Tenant = `tenants/${tenantId}/css/variables.css?v=${s}`;
    let L2Tenant = `tenants/${tenantId}/css/app.css?v=${s}`;

    let VarLink = makeLink(TenantVar, L1Tenant);
    let CssLink = makeLink(TenantCss, L2Tenant);

    let head = document.getElementsByTagName("head")[0];

    head.querySelector("#" + TenantVar).remove();
    head.querySelector("#" + TenantCss).remove();
    head.appendChild(VarLink);
    head.appendChild(CssLink);
}

export function clearGlobalTheme() {        

    let s = makeid(15);

    let L1 = `css/themes/default/variables.css?v=${s}`;
    let L2 = `css/themes/default/app.css?v=${s}`;

    let VarLink = makeLink(GlobalVar, L1);
    let CssLink = makeLink(GlobalCss, L2);
        
    let head = document.getElementsByTagName("head")[0];

    console.log(head);

    head.querySelector("#" + GlobalVar).remove();
    head.querySelector("#" + GlobalCss).remove();
    head.appendChild(VarLink);
    head.appendChild(CssLink);
}

export function clearTenantTheme() {

    let s = makeid(15);

    let ss = `css/themes/default/`;

    let L1 = ss + `variables.css?v=${s}`;
    let L2 = ss + `app.css?v=${s}`;

    let VarLink = makeLink(TenantVar, L1);
    let CssLink = makeLink(TenantCss, L2);

    let head = document.getElementsByTagName("head")[0];
    head.querySelector("#" + TenantVar).remove();
    head.querySelector("#" + TenantCss).remove();
    head.appendChild(VarLink);
    head.appendChild(CssLink);
}

let GlobalCss = "globalTheme";
let GlobalVar = "globalThemeVariables";
let TenantCss = "tenantTheme";
let TenantVar = "tenantThemeVariables";

function makeLink(themeId, themePath) {

    let newLink = document.createElement("link");
    newLink.setAttribute("id", themeId);
    newLink.setAttribute("rel", "stylesheet");
    newLink.setAttribute("type", "text/css");
    newLink.setAttribute("href", themePath);

    return newLink;
}

function makeid(length) {
    let result = '';
    const characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
    const charactersLength = characters.length;
    let counter = 0;
    while (counter < length) {
        result += characters.charAt(Math.floor(Math.random() * charactersLength));
        counter += 1;
    }
    return result;
}