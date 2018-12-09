class Blog extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {

        const blolist = this.props.bdata.map(b => (
            <div className="col-lg-4">
                <h1>{b.Title}</h1>
                <p>{b.ShortDescription}</p>
                <p>{b.Body}</p>
            </div>
        ));

        return (blolist);
    }
}




                //For displaying text in page
//class Hello extends React.Component
//{
//    constructor(props) {
//        super(props);
//        this.state =
//            {
//                name: "Jakub B"
//            };
//    }
//    render() {
//        return (<h1>Hello {this.props.name}</h1>);
//    }
//}