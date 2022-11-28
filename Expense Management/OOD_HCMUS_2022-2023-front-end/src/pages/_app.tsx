import { AppProps } from 'next/app';
import Head from 'next/head';
import { Provider } from 'react-redux';
import store from 'src/redux/index';
import Alert from 'react-s-alert';

import 'react-s-alert/dist/s-alert-default.css';
import 'react-s-alert/dist/s-alert-css-effects/slide.css';

import '../resources/global.css'
import '../resources/font-awesome6pro/css/all.min.css'
// import 'antd/dist/antd.css';

function App({ Component, pageProps }: AppProps) {
  return (
    <>
      <Head>

        <meta charSet="utf-8" />
        <meta httpEquiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content={"Monoleak"} />
        <meta name="author" content={"anho"} />
        <title>Monoleak</title>
        <link rel="icon" href="/img/favicon.png" type="image/x-icon" />
        <link rel="shortcut icon" href="/img/favicon.png" type="image/x-icon" />

        {/* CSS custom */}
        <link href="./assets/css/main.css" rel="stylesheet" />
       
      </Head>

      <Alert stack={{ limit: 3 }} />
      <Provider store={store}>
        <Component {...pageProps} />
      </Provider>

    </>
  )
}

export default App
