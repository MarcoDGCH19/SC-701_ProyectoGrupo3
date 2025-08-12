window.destroyParticles = () => {
    if (window.pJSDom && window.pJSDom.length > 0) {
        window.pJSDom[0].pJS.fn.vendors.destroypJS();
        window.pJSDom = [];
    }
};

window.setUserColor = function (color) {
    document.documentElement.style.setProperty('--user-color', color);
    document.body.style.backgroundImage = `linear-gradient(180deg, rgb(5, 39, 103) 0%, ${color} 70%)`;
};

window.loadParticleScript = function (effectName) {
    const script = document.createElement("script");
    script.src = `js/${effectName}.js`;
    script.onload = () => {
        if (typeof window[effectName] === 'function') {
            window[effectName]();
        } else {
            console.warn(`Función ${effectName} no encontrada.`);
        }
    };
    document.body.appendChild(script);
};