function hello(compiler: string) {
    let BaseForm: Xrm.BasicPage;
    BaseForm.getAttribute("name").getIsDirty();
    console.log(`Hello from ${compiler}`);
}
hello('TypeScript');