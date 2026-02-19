const html = window.igTemplating.html;
igRegisterScript("columnBodyTemplateScript", (ctx) => {
    return html`
        <igc-button variant="flat" type="button" customers-scope @click=${() => window.dotNetHelper.invokeMethodAsync('clickButton1', ctx)} class="button_2">
            ${ctx.cell.value}
        </igc-button>
    `
}, false);
igRegisterScript("columnBodyTemplateScript1", (ctx) => {
    return html`
        <igc-chip customers-scope class="chip">
            <span customers-scope slot="prefix">
                <span customers-scope class="material-icons icon_1">
                    phone
                </span>
            </span>
            ${ctx.cell.value}
        </igc-chip>
    `
}, false);

window.setDotNetRef = (dotNetHelper) => {
    window.dotNetHelper = dotNetHelper;
}
